using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CloudBar.Domain.Sale;
using CloudBar.BusinessLogic.Services.Contracts;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : BaseController<Order>
    {
        private readonly ISaleOrderService _saleOrderService;
        public SalesController(ISaleOrderService baseService) : base(baseService)
        {
            _saleOrderService = baseService;
        }

        [HttpPost]        
        public override IActionResult Post(Order order)
        {
            order.Number = _saleOrderService.GenerateSaleOrderNumber();

            var response = _saleOrderService.Add(order);

            return Ok(response);
        }
    }
}
