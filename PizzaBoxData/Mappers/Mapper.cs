using System.Linq;
using PizzaBoxData.Entities;

namespace PizzaBoxData
{
  public class Mapper
  {
    public static PizzaBoxDomain.Models.Order Map(PizzaBoxData.Entities.Order order)
    {
      PizzaBoxDomain.Models.Order o = new PizzaBoxDomain.Models.Order();
      o.Customer = new PizzaBoxDomain.Models.Customer();
      o.Customer.customerID = order.UserName;
      //o.Store = new PizzaBoxDomain.Models.Store();
     // o.Store.Name = order.StoreName;
      o.Time = order.TimeReceived;
      o.Summary = order.Summary;
           
      //o.GetPrice() = order.Total;
      //order.Summary = o.ToString();
      // order.TimeReceived = new System.DateTime();
      return o;

    }
    public static PizzaBoxData.Entities.Order Map(PizzaBoxDomain.Models.Order order, Context context)
    {
      PizzaBoxData.Entities.Order o = new PizzaBoxData.Entities.Order();
     // o.Store = Map(order.Store, context);
     // o.StoreName = o.Store.StoreName;
      o.User = Map(order.User, context);
      o.UserName = o.User.UserName;
           
      o.Total = order.GetPrice();
      o.Summary = order.ToString();
      o.TimeReceived = System.DateTime.Now;

      return o;
    }
    public static PizzaBoxData.Entities.User Map(PizzaBoxDomain.Models.User user, Context context)
    {
      if (user != null)
      {
        var dbUser = context.Users.FirstOrDefault(u => u.UserId == user.userID);
        if (dbUser != null)
        {
          return dbUser;
        }
      }
      PizzaBoxData.Entities.User u = new PizzaBoxData.Entities.User();
            if (user != null)
            {
                u.UserId = user.userID;
                u.UserName = user.userName;
                u.UserPhone = user.userPhone;
            }
      return u;
    }
    public static PizzaBoxDomain.Models.User Map(PizzaBoxData.Entities.User user)
    {
      PizzaBoxDomain.Models.User u = new PizzaBoxDomain.Models.User();
      u.userID = user.UserId;
      u.userName = user.UserName;
      u.userPhone = user.UserPhone;
      return u;
    }

    public static PizzaBoxData.Entities.Store Map(PizzaBoxDomain.Models.Store store, Context context)
    {
      if (store != null)
      {
        var dbStore = context.Stores.FirstOrDefault(s => s.StoreId == store.StoreId);
        if (dbStore != null)
        {
          return dbStore;
        }
      }

      PizzaBoxData.Entities.Store s = new PizzaBoxData.Entities.Store();
            if (store != null)
            {
                s.StoreId = store.StoreId;
                s.StoreName = store.Name;
                
            }
            return s;
        }
    public static PizzaBoxDomain.Models.Store Map(PizzaBoxData.Entities.Store store)
    {
      PizzaBoxDomain.Models.Store s = new PizzaBoxDomain.Models.Store();
      s.StoreId = store.StoreId;
      s.Name = store.StoreName;
      return s;
    }

  }
}
