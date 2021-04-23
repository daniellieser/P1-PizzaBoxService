using System;
using System.ComponentModel.DataAnnotations; // validations
using System.ComponentModel.DataAnnotations.Schema; //constraints and display

namespace PizzaBoxData.Entities
{
    [Table("Order")]
    public partial class Order
    {
        public Order() 
        { 

        }
        public Order(string UserName, string StoreName, DateTime? TimeReceived, decimal Total, string Summary, int OrderId, int? UserId, int? StoreId )
        {
    

        }
        public string UserName { get; set; }
        public string StoreName { get; set; }
        public DateTime? TimeReceived { get; set; }
        public decimal? Total { get; set; }
        public string Summary { get; set; }
        [Key]
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? StoreId { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
