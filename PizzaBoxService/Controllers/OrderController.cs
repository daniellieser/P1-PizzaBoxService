using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBoxDomain.Models;
using PizzaBoxData.Entities;
using PizzaBoxData;

namespace PizzaBoxService.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        PizzaBoxData.Entities.Context context;
        public OrderController(PizzaBoxData.Entities.Context context)
        {
            this.context = context;
        }
        // [HttpPost("{placeOrder}")]
        // [ProducesResponseType(StatusCodes.Status201Created)]
        // public IActionResult Post([FromBody]Order order) 
        //{
        //add Order to Context
        //    context.Add(order);
        //    return NoContent();
        // }
      
        [HttpGet("GetAllOrders")]
        public IEnumerable<PizzaBoxDomain.Models.Order> GetAllOrders()
        {
            var allOrders = context.Orders.Select(x => Mapper.Map(x));
            return allOrders.ToList();
        }



        [HttpPost]

         [ProducesResponseType(StatusCodes.Status201Created)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Save(PizzaBoxDomain.Models.Order order)
        {
            var mappedOrder = Mapper.Map(order, context);
            System.Diagnostics.Debug.WriteLine(" API OrderController  userid: " + order.UserId);
            System.Diagnostics.Debug.WriteLine(" API OrderController  storeID: " + order.StoreId);
            System.Diagnostics.Debug.WriteLine(" API OrderController  summary: " + order.Summary);
            System.Diagnostics.Debug.WriteLine(" Mapper OrderController  userid: " + mappedOrder.UserId);
            System.Diagnostics.Debug.WriteLine(" Mapper OrderController  storeID: " + mappedOrder.StoreId);
            System.Diagnostics.Debug.WriteLine(" Mapper OrderController  summary: " + mappedOrder.Summary);
            var result = context.Add(mappedOrder);
            var orderFromContext = result.Entity;
            System.Diagnostics.Debug.WriteLine(" Mapper OrderController  orderFromContext.userid: " + orderFromContext.UserId);
            System.Diagnostics.Debug.WriteLine(" Mapper OrderController  orderFromContext.storeID: " + orderFromContext.StoreId);
            System.Diagnostics.Debug.WriteLine(" Mapper OrderController  orderFromContext.summary: " + orderFromContext.Summary);

            context.SaveChanges();
        }


    }
}
