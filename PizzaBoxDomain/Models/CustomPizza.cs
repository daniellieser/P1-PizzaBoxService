using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomPizza : APizza
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
      Toppings.Add(new Cheese());
      Toppings.Add(new Sauce());
    }
    public override string ToString()
    {
      return "Custom Pizza";
    }
    public override APizza GetClone()
    {
      APizza pizza = new CustomPizza();
      pizza.Crust = this.Crust;
      pizza.Size = this.Size;
      pizza.Toppings = this.Toppings;
      return pizza;
    }

  }
}
