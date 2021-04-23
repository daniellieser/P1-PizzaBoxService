using System.Collections.Generic;


namespace PizzaBoxDomain
{
  public interface IRepository
  {



    void Save(PizzaBoxDomain.Models.Order order);
  }
}