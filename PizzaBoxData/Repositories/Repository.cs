using PizzaBoxDomain;
//using PizzaBoxDomain.Interfaces;
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
      context.Add(OrderMapper.Map(order, context));
      context.SaveChanges();
    }
    public void Save(PizzaBoxDomain.Models.Store store)
    {
      context.Add(OrderMapper.Map(store, context));
      context.SaveChanges();
    }
    public void Save(PizzaBoxDomain.Models.User user)
    {
      context.Add(OrderMapper.Map(user, context));
      context.SaveChanges();
    }
    public List<PizzaBoxDomain.Models.Order> GetStoreOrders(int storeId)
    {
      var storeOrders = context.Orders.Where(x => x.StoreId == storeId);
      return storeOrders.Select(OrderMapper.Map).ToList();
    }
    public List<PizzaBoxDomain.Models.Order> GetCustOrders(int custId)
    {
      var custOrders = context.Orders.Where(x => x.UserId == custId);
      return custOrders.Select(OrderMapper.Map).ToList();
    }
    public List<PizzaBoxDomain.Models.Store> GetStores()
    {
      var allStores = context.Stores.Select(x => OrderMapper.Map(x));
      return allStores.ToList();
    }
    // public int GetLastTime(int UserID)
    // {
    //   var lastOrderTime = context.Orders.TimeReceived(x => x.)
    //   return lastOrderTime.Select(OrderMapper.Map);
    // }


    private readonly PizzaBoxData.Entities.Context context;

  }
}
