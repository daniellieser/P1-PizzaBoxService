using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Topping : AComponent
  {
    public Topping(string Name, decimal Price)
    {
      this.Name = Name;
      this.Price = Price;
    }
  }

}
