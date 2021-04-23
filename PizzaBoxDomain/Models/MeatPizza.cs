using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class MeatPizza : APizza
  {
    public override void SetCrust()
    {
      Crust = new NYStyle();
    }

    public override void SetSize()
    {
      Size = new FourteenInch();
    }
    public override void AddToppings()
    {
      Toppings.Add(new Bacon());
      Toppings.Add(new Cheese());
      Toppings.Add(new Sauce());
      Toppings.Add(new Sausage());
      Toppings.Add(new Pepperoni());
    }
    public override string ToString()
    {
      return "Meat Pizza";
    }
    public override APizza GetClone()
    {
      APizza pizza = new MeatPizza();
      pizza.Crust = this.Crust;
      pizza.Size = this.Size;
      pizza.Toppings = this.Toppings;
      return pizza;
    }
  }

}

