using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Musisz wpisać swoje imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Musisz podać adres wysyłki")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Musisz podać miasto, do którego chcesz dostarczyć zamówienie")]
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}