using System.Linq;
using PizzaBoxData.Entities;

namespace PizzaBoxData
{
  public class Mapper
  {
    public static PizzaBoxDomain.Models.Order Map(PizzaBoxData.Entities.Order order)
    {
      PizzaBoxDomain.Models.Order o = new PizzaBoxDomain.Models.Order();
      o.User = new PizzaBoxDomain.Models.User();
      o.OrderId = order.OrderId;
      o.UserId = order.UserId;
      o.StoreId = order.StoreId;
     // o.Customer.customerID = order.UserName;
      //o.Store = new PizzaBoxDomain.Models.Store();
     // o.Store.Name = order.StoreName;
      o.TimeReceived = order.TimeReceived;
      o.Summary = order.Summary;
           
      //o.GetPrice() = order.Total;
      //order.Summary = o.ToString();
      // order.TimeReceived = new System.DateTime();
      return o;

    }
    public static PizzaBoxData.Entities.Order Map(PizzaBoxDomain.Models.Order order, Context context)
    {
      PizzaBoxData.Entities.Order o = new PizzaBoxData.Entities.Order();
   
      o.StoreId = order.StoreId;
      o.UserId = order.UserId;
      o.OrderId = order.OrderId;     
      o.Total = order.GetPrice();
      o.Summary = order.Summary;
      o.TimeReceived = System.DateTime.Now;

      return o;
    }
    public static PizzaBoxData.Entities.User Map(PizzaBoxDomain.Models.User user, Context context)
    {
            // if (user != null)
            //{
            // var dbUser = context.Users.FirstOrDefault(u => u.UserId == user.userID);
            // if (dbUser != null)
            // {
            //   return dbUser;
            // }
            //}
            System.Diagnostics.Debug.WriteLine(" Mapper   userid: " + user.userID);
            System.Diagnostics.Debug.WriteLine(" Mapper   username: " + user.userName);
            System.Diagnostics.Debug.WriteLine(" Mapper   phone: " + user.userPhone);
            PizzaBoxData.Entities.User u = new PizzaBoxData.Entities.User();
           // if (user != null)
           // {
                u.UserId = user.userID;
                u.UserName = user.userName;
                u.UserPhone = user.userPhone;
            //}
      return u;
    }
    public static PizzaBoxDomain.Models.User Map(PizzaBoxData.Entities.User user)
    {
         
            PizzaBoxDomain.Models.User u = new PizzaBoxDomain.Models.User();
            System.Diagnostics.Debug.WriteLine(" Mapper   userid: " + u.userID);
            System.Diagnostics.Debug.WriteLine(" Mapper   username: " + u.userName);
            System.Diagnostics.Debug.WriteLine(" Mapper   phone: " + u.userPhone);
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
