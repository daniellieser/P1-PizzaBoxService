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
    public class PizzaBoxController : ControllerBase
    {
        PizzaBoxData.Entities.Context context;
        public PizzaBoxController(PizzaBoxData.Entities.Context context)
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



         [HttpPost("{order}")]
         [ProducesResponseType(StatusCodes.Status201Created)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Save(PizzaBoxDomain.Models.Order order)
        {
             context.Add(Mapper.Map(order, context));
             context.SaveChanges();
         }


    }
}
