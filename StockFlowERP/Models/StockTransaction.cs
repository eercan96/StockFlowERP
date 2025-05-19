using System;

namespace StockFlowERP.Models
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; } // "In" or "Out"
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
} 