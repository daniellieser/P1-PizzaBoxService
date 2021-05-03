using PizzaBoxDomain.Abstracts;
using PizzaBoxDomain;
using System;
//using PizzaBox.Storing;
using System.Collections.Generic;


namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {
    //public Store Store { get; set; }
  // public Customer Customer { get; set; }
    public string UserName { get; set; }
    public List<APizza> Pizzas { get; set; }
    public string Summary { get; set; }
    public User User { get; set; }
    public int OrderId { get; set; }
    public int? StoreId { get; set; }
   public int? UserId { get; set; }
   public DateTime? TimeReceived { get; set; }

    public Order()
    {
     //Store = new Store();
      //Customer = new Customer();
      User = new User();
      Pizzas = new List<APizza>();
      
    }
    public virtual decimal GetPrice()
    {
      decimal sum = 0;
      if (Pizzas != null)
      {
        foreach (APizza pizza in Pizzas)
        {
          sum += pizza.GetPrice();
        }
        return sum;
      }
      else { return 0; }
    }
    public override string ToString()
    {
      string summary = "Order Summary: ";
      if (Pizzas != null)
      {
        foreach (APizza pizza in Pizzas)
        {
          summary += pizza.Size.ToString();
          summary += " ";
          summary += pizza.Crust;
          summary += " ";
          summary += pizza;
          foreach (Topping topping in pizza.Toppings)
          {
            summary += " ";
            summary += topping.Name;
            summary += " ";
          }
        }
      }
      summary += " , Price is: " + GetPrice();
      // summary += " , Customer is " + Customer.customerID;
      // summary += " , Store is " + Store.ToString();
      return summary;


    }
    public void Save()
    {

    }
  }
}
