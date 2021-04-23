using PizzaBoxDomain.Abstracts;

namespace PizzaBoxDomain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class ChicagoStore : AStore
  {
    /// <summary>
    /// 
    /// </summary>
    public ChicagoStore()
    {
      Name = "ChicagoStore";
    }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
