using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Domain.Aggregates.ClientAggregate;
using VHElegantAttire.Domain.Aggregates.ProductAggregate;

namespace VHElegantAttire.Domain.Aggregates.OrderAggregate
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = new Client();
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
