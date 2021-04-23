using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBoxDomain.Abstracts
{
  /// <summary>
  /// Represents the Store Abstract Class
  /// </summary>
  [XmlInclude(typeof(ChicagoStore))]
  [XmlInclude(typeof(NewYorkStore))]
  public class AStore
  {
    public string Name { get; set; }

    public AStore()
    {

    }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
