using System.Collections.Generic;
using PizzaBoxDomain.Models;

namespace PizzaBoxDomain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  public class APizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }


    public APizza()
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
        public virtual APizza GetClone() 
        {
            APizza pizza = new CustomPizza();
            pizza.Crust = this.Crust;
            pizza.Size = this.Size;
            pizza.Toppings = this.Toppings;
            return pizza;
        }

        public virtual void SetCrust() { }

        public virtual void SetSize() { }

        public virtual void AddToppings() { }

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
