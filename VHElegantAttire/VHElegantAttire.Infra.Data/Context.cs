using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Application.Abstractions;
using VHElegantAttire.Domain.Aggregates.ProductAggregate;

namespace VHElegantAttire.Infra.Data
{
    public class Context : DbContext, IUnitOfWork
    {
        public Context( DbContextOptions<Context> options) : base(options)
        {
            
        }   
        

        public DbSet<Product> Products { get; set; }
    }
}
