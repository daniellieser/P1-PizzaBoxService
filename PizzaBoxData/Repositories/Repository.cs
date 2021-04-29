using PizzaBoxDomain;
using System.Threading.Tasks;
using PizzaBoxDomain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBoxData
{
  public class Repository : IRepository
  {
         
    public Repository(PizzaBoxData.Entities.Context context)
    {
      this.context = context;
    }

    public void Save(PizzaBoxDomain.Models.Order order)
    {
      context.Add(Mapper.Map(order, context));
      context.SaveChanges();
    }
    public void Save(PizzaBoxDomain.Models.Store store)
    {
      context.Add(Mapper.Map(store, context));
      context.SaveChanges();
    }
    public void Save(PizzaBoxDomain.Models.User user)
    {
      context.Add(Mapper.Map(user, context));
      context.SaveChanges();
    }
    public List<PizzaBoxDomain.Models.Order> GetStoreOrders(int storeId)
    {
      var storeOrders = context.Orders.Where(x => x.StoreId == storeId);
      return storeOrders.Select(Mapper.Map).ToList();
    }
        public List<PizzaBoxDomain.Models.Order> GetAllOrders()
        {
            var allOrders = context.Orders;
            return allOrders.Select(Mapper.Map).ToList();
        }
        public List<PizzaBoxDomain.Models.Order> GetCustOrders(int custId)
    {
      var custOrders = context.Orders.Where(x => x.UserId == custId);
      return custOrders.Select(Mapper.Map).ToList();
    }
    public List<PizzaBoxDomain.Models.Store> GetStores()
    {
      var allStores = context.Stores.Select(x => Mapper.Map(x));
      return allStores.ToList();
    }
   

    private readonly PizzaBoxData.Entities.Context context;

  }
}
