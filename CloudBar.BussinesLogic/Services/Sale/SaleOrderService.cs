using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Common.Models;
using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Sale;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Sale
{
    public class SaleOrderService : BaseService<Order>, ISaleOrderService
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        private readonly IDataRepository<Order> _baseRepository;
        private readonly IDataRepository<OrderLine> _orderLineRepository;
        private readonly IDataRepository<Invoice> _invoiceRepository;
        private readonly IDataRepository<InvoiceLine> _invoiceLineRepository;
        public SaleOrderService(IDataRepositoryFactory dataRepositoryFactory, 
                                IDataRepository<Order> baseRepository,
                                IDataRepository<OrderLine> orderLineRepository,
                                IDataRepository<Invoice> invoiceRepository,
                                IDataRepository<InvoiceLine> invoiceLineRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
            _baseRepository = baseRepository;
            _orderLineRepository = orderLineRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceLineRepository = invoiceLineRepository;
        }

        public OrderLine CreateLine(OrderLine line)
        {
            line.Active = true;

            var response = _orderLineRepository.Add(line);

            UpdateSaleOrderFromLines(response);

            return response;
        }        

        public OrderLine UpdateLine(OrderLine line)
        {
            var response = _orderLineRepository.Update(line);

            UpdateSaleOrderFromLines(response);

            return response;
        } 

        public string GenerateSaleOrderNumber()
        {
            var lastOrder = _baseRepository.GetAll().OrderByDescending(or => or.Id).FirstOrDefault();

            if (lastOrder == null) return "0000001";

            int countDigit = int.Parse(lastOrder.Number).ToString().Length;

            int lastDigit = int.Parse(lastOrder.Number) + 1;

            return new string('0', 7 - countDigit) + lastDigit.ToString();
        }

        public string GenerateInvoiceNumber()
        {
            var lastOrder = _invoiceRepository.GetAll().OrderByDescending(or => or.Id).FirstOrDefault();

            if (lastOrder == null) return "0000001";

            int countDigit = int.Parse(lastOrder.Number).ToString().Length;

            int lastDigit = int.Parse(lastOrder.Number) + 1;

            return new string('0', 7 - countDigit) + lastDigit.ToString();
        }

        private void UpdateSaleOrderFromLines(OrderLine line)
        {
            var order = _baseRepository.Get(orders => orders.Include(or => or.Lines),
                                            order => order.Id == line.OrderId);

            if (order.StatusId != (int)OrderStatus.InProcess)
                order.StatusId = (int)OrderStatus.InProcess;

            order.Total = order.Lines.Sum(item => item.Price * item.Quantity);

            _baseRepository.Update(order);
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            invoice.Order = _baseRepository.Get(invoice.OrderId);

            invoice.Order.StatusId = (int)OrderStatus.Paid;

            return _invoiceRepository.Add(invoice);
        }
    }
}