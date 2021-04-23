using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Size : AComponent
  {
    public Size(string Name, decimal Price)
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
