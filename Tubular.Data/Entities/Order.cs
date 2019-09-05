using System;

namespace Tubular.Data.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipperCity { get; set; }
        public decimal Amount { get; set; }
        public bool IsShipped { get; set; }
    }
}
