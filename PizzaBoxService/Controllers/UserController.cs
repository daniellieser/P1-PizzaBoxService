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
    public class UserController : ControllerBase
    {
        PizzaBoxData.Entities.Context context;
        public UserController(PizzaBoxData.Entities.Context context)
        {
            this.context = context;
        }
      

        // GET api/<CustOrderController>/5
        [HttpGet("{custId}")]
        public IEnumerable<PizzaBoxDomain.Models.Order> GetCustOrders(int custId)
        {
            var custOrders = context.Orders.Where(x => x.UserId == custId).ToList();
            return custOrders.Select(Mapper.Map).ToList();
        }

        [HttpPost("{user}")]
        public void Save(PizzaBoxDomain.Models.User user)
        {
            context.Add(Mapper.Map(user, context));
            context.SaveChanges();

        }




    }
}
