using System;

namespace OrderApi.Database.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public string Client { get; set; }

        public string Product { get; set; }

        public string Quantity { get; set; }

        public string Price { get; set; }

        public DateTime Date { get; set; }

        public bool IsShipped { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }
    }
}
