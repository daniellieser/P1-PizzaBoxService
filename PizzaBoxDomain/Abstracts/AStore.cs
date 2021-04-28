using System.Xml.Serialization;
using PizzaBoxDomain.Models;

namespace PizzaBoxDomain.Abstracts
{
  /// <summary>
  /// Represents the Store Abstract Class
  /// </summary>
 
  public class AStore
  {
    public string Name { get; set; }
    public int StoreId { get; set; }

    public AStore()
    {

    }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
