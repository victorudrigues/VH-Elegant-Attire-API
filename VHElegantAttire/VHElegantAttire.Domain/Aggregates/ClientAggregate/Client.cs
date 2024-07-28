using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Domain.Aggregates.OrderAggregate;

namespace VHElegantAttire.Domain.Aggregates.ClientAggregate
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
