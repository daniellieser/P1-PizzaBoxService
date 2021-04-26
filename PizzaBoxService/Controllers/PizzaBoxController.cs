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
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaBoxController : ControllerBase
    {
        PizzaBoxData.Entities.Context context;
        public void Repository(PizzaBoxData.Entities.Context context)
        {
            this.context = context;
        }

        [HttpGet("int/{id:int}")]
        public IEnumerable<PizzaBoxDomain.Models.Order> GetCustOrders(int custId)
        {
            var custOrders = context.Orders.Where(x => x.UserId == custId).ToList();
            return custOrders.Select(Mapper.Map).ToList();
        }
        [HttpGet]
        public IEnumerable<PizzaBoxDomain.Models.Order> GetStoreOrders(int storeId)
        {
            var storeOrders = context.Orders.Where(x => x.StoreId == storeId);
            return storeOrders.Select(Mapper.Map).ToList();
        }
        [HttpGet]
        public IEnumerable<PizzaBoxDomain.Models.Store> GetStores()
        {
            var allStores = context.Stores.Select(x => Mapper.Map(x));
            return allStores.ToList();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Save(PizzaBoxDomain.Models.Order order)
        {
            context.Add(Mapper.Map(order, context));
            context.SaveChanges();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Save(PizzaBoxDomain.Models.Store store)
        {
            context.Add(Mapper.Map(store, context));
            context.SaveChanges();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Save(PizzaBoxDomain.Models.User user)
        {
            context.Add(Mapper.Map(user, context));
            context.SaveChanges();

        }
    }
}
