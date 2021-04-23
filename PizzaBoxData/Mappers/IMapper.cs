using PizzaBoxDomain;

namespace PizzaBoxData
{
  public interface IMapper<Database, Domain>
  {
    Domain Map(Database model);
    Database Map(Domain model);

  }
}