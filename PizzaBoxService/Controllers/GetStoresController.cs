using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBoxData;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaBoxService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetStoresController : ControllerBase
    {
        
        
        PizzaBoxData.Entities.Context context;
        
        public GetStoresController(PizzaBoxData.Entities.Context context)
        {
            this.context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet("GetStores")]
        public IEnumerable<PizzaBoxDomain.Models.Store> GetStores()
        {
            var allStores = context.Stores.Select(x => Mapper.Map(x));
            return allStores.ToList();
        }
       // public List<PizzaBoxDomain.Models.Store> GetStores()
       // {
       //     var allStores = context.Stores.Select(x => Mapper.Map(x));
       //     return allStores.ToList();
        //}



    }
}
