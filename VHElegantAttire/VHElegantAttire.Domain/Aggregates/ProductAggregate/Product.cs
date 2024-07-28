using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Domain.Aggregates.StockAggregate;

namespace VHElegantAttire.Domain.Aggregates.ProductAggregate
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int StockId { get; set; }
        public Stock Stock { get; set; } = new Stock();
    }
}
