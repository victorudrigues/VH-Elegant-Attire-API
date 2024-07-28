using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Domain.Aggregates.ProductAggregate;

namespace VHElegantAttire.Domain.Aggregates.StockAggregate
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
