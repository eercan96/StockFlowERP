using System.Collections.Generic;

namespace StockFlowERP.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public ICollection<Product> Products { get; set; }
    }
} 