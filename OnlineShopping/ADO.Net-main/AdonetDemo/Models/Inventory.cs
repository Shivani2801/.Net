using System;
using System.Collections.Generic;

namespace AdonetDemo.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
