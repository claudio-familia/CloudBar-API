using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CloudBar.Domain.Sale;
using CloudBar.BusinessLogic.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using CloudBar.Common.Models;
using CloudBar.DataAccess.Repositories.Contracts;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : BaseController<Order>
    {
        private readonly ISaleOrderService _saleOrderService;
        private readonly IBaseService<Invoice> _invoiceService;
        public SalesController(ISaleOrderService baseService, IBaseService<Invoice> invoiceService) : base(baseService)
        {
            _saleOrderService = baseService;
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public override IActionResult Get(string sortExpression)
        {
            var response = _saleOrderService.GetAll(order => order.Include(or => or.Creator)
                                                                  .Include(or => or.Lines)
                                                                  .Include(or => or.Status)
                                                                  .Include(or => or.Client)
                                                                  .ThenInclude(or => or.Person)
                                                                  .Include(or => or.Employee)
                                                                  .ThenInclude(or => or.Person), 
                                                     order => order.Active.Value);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            var response = _saleOrderService.Get(orders => orders.Include(or => or.Creator)
                                                                 .Include(or => or.Lines)
                                                                 .Include(or => or.Lines)
                                                                 .ThenInclude(or => or.Item)
                                                                 .Include(or => or.Client)
                                                                 .ThenInclude(or => or.Person)
                                                                 .Include(or => or.Employee)
                                                                 .Where(order => order.Id == id));

            if (response == null) return NotFound();

            return Ok(response);
        }

        [HttpPost]        
        public override IActionResult Post(Order order)
        {
            order.Number = _saleOrderService.GenerateSaleOrderNumber();

            order.StatusId = (int)OrderStatus.Open;

            var response = _saleOrderService.Add(order);

            return Ok(response);
        }

        [HttpPost("invoice")]
        public IActionResult PostInvoice(Invoice invoice)
        {
            invoice.Number = _saleOrderService.GenerateSaleOrderNumber();

            var response = _saleOrderService.CreateInvoice(invoice);

            return Ok(response);
        }

        [HttpGet]
        [Route("clients/{id}")]
        public IActionResult GetByClients(int id)
        {
            var response = _saleOrderService.GetAll(order => order.Include(or => or.Creator)
                                                                  .Include(or => or.Lines)
                                                                  .Include(or => or.Status)
                                                                  .Include(or => or.Client)
                                                                  .ThenInclude(or => or.Person)
                                                                  .Include(or => or.Employee)
                                                                  .ThenInclude(or => or.Person),
                                                     order => order.Active.Value && order.ClientId == id);

            return Ok(response);
        }

        [HttpGet]
        [Route("invoice/{id}")]
        public IActionResult GetInvoice(int id)
        {
            var response = _invoiceService.Get(invoice => invoice.Include(i => i.Lines)
                                                                 .Include(i => i.Order)
                                                                 .ThenInclude(or => or.Lines),
                                               invoice => invoice.OrderId == id);

            return Ok(response);
        }


        [HttpPost("lines")]
        public IActionResult PostLine(OrderLine line)
        {
            var response = _saleOrderService.CreateLine(line);

            return Ok(response);
        }

        [HttpPut("lines")]
        public IActionResult PutLine(OrderLine line)
        {
            var response = _saleOrderService.UpdateLine(line);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _saleOrderService.Get(id);

            order.Active = false;

            var response = _saleOrderService.Update(order);

            return Ok(response);
        }
    }
}
