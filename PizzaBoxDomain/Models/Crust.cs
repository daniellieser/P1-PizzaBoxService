using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Crust : AComponent
  {
    public Crust(string Name, decimal Price)
    {
      this.Name = Name;
      this.Price = Price;
    }
    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
