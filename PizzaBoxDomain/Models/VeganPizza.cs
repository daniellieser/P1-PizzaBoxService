using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class VeganPizza : APizza
  {
    public override void SetCrust()
    {
      Crust = new DeepDish();
    }
    public override void SetSize()
    {
      Size = new FourteenInch();
    }

    public override void AddToppings()
    {
      Toppings.Add(new VeganCheese());
      Toppings.Add(new Onions());
      Toppings.Add(new Sauce());
    }
    public override string ToString()
    {
      return "Vegan Pizza";
    }
    public override APizza GetClone()
    {
      APizza pizza = new VeganPizza();
      pizza.Crust = this.Crust;
      pizza.Size = this.Size;
      pizza.Toppings = this.Toppings;
      return pizza;
    }
  }
}
