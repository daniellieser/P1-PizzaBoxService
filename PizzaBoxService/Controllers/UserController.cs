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

        //[HttpPost("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Save(PizzaBoxDomain.Models.User user)
        {
            var mappedUser = Mapper.Map(user, context);
            System.Diagnostics.Debug.WriteLine(" UserController   userid: " + user.UserId);
            System.Diagnostics.Debug.WriteLine(" UserController   username: " + user.UserName);
            System.Diagnostics.Debug.WriteLine(" UserController   phone: " + user.UserPhone);
            System.Diagnostics.Debug.WriteLine("  UserController   userid: " + mappedUser.UserId);
            System.Diagnostics.Debug.WriteLine("  UserController   username: " + mappedUser.UserName);
            System.Diagnostics.Debug.WriteLine("  UserController   phone: " + mappedUser.UserPhone);
            var result = context.Add(mappedUser);
            var userFromContext = result.Entity;
            System.Diagnostics.Debug.WriteLine("  UserController userFromContext  userid: " + userFromContext.UserId);
            System.Diagnostics.Debug.WriteLine("  UserController userFromContext  username: " + userFromContext.UserName);
            System.Diagnostics.Debug.WriteLine("  UserController  userFromContext phone: " + userFromContext.UserPhone);

            context.SaveChanges();

        }




    }
}
