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
     
            PizzaBoxData.Entities.User u = new PizzaBoxData.Entities.User();
            System.Diagnostics.Debug.WriteLine(" Mapper Entities from parameter userid: " + user.UserId);
            System.Diagnostics.Debug.WriteLine(" Mapper Entities from parameter username: " + user.UserName);
            System.Diagnostics.Debug.WriteLine(" Mapper Entities from parameter phone: " + user.UserPhone);
          
          
                u.UserId = user.UserId;
                u.UserName = user.UserName;
                u.UserPhone = user.UserPhone;

            System.Diagnostics.Debug.WriteLine(" Mapper Entities new assigned User userid: " + u.UserId);
            System.Diagnostics.Debug.WriteLine(" Mapper Entities new assigned User username: " + u.UserName);
            System.Diagnostics.Debug.WriteLine(" Mapper Entities new assigned User phone: " + u.UserPhone);

            return u;
    }
    public static PizzaBoxDomain.Models.User Map(PizzaBoxData.Entities.User user)
    {
         
            PizzaBoxDomain.Models.User u = new PizzaBoxDomain.Models.User();
            System.Diagnostics.Debug.WriteLine(" Mapper Domain  userid: " + u.UserId);
            System.Diagnostics.Debug.WriteLine(" Mapper  Domain username: " + u.UserName);
            System.Diagnostics.Debug.WriteLine(" Mapper Domain  phone: " + u.UserPhone);
            u.UserId = user.UserId;
      u.UserName = user.UserName;
      u.UserPhone = user.UserPhone;
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
