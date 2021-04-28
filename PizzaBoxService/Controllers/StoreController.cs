using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBoxData;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaBoxService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        PizzaBoxData.Entities.Context context;
        public StoreController(PizzaBoxData.Entities.Context context)
        {
            this.context = context;
        }
        // GET: api/<ValuesController>
       // [HttpGet("{store}")]
       // public IEnumerable<PizzaBoxDomain.Models.Order> GetStoreOrders(int storeId)
       // {
       //     var storeOrders = context.Orders.Where(x => x.StoreId == storeId);
       //     return storeOrders.Select(Mapper.Map).ToList();
       // }

        

        //[HttpPost("{store}")]
 
        //public void Save(PizzaBoxDomain.Models.Store store)
        //{
         //   context.Add(Mapper.Map(store, context));
        //    context.SaveChanges();
        //}

    
    }
}
