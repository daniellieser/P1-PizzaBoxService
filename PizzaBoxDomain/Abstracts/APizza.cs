using System.Collections.Generic;
using PizzaBoxDomain.Models;

namespace PizzaBoxDomain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  public abstract class APizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }


    protected APizza()
    {
      Toppings = new List<Topping>();
      Factory();
    }

    private void Factory()
    {
      SetCrust();
      SetSize();
      AddToppings();
    }
    public abstract APizza GetClone();

    public abstract void SetCrust();

    public abstract void SetSize();

    public abstract void AddToppings();

    public virtual decimal GetPrice()
    {
      decimal sum = 0;
      foreach (Topping topping in Toppings)
      {
        sum += topping.Price;
      }
      sum += Crust.Price;
      sum += Size.Price;
      return sum;
    }
    public override string ToString()
    {
      return base.ToString() + " - Size: " + Size.Name + " - Crust: " + Crust.Name + " - Price: " + GetPrice();

    }

  }
}
