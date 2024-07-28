using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Application.Abstractions.Features.ProductCrud.Repository;
using VHElegantAttire.Domain.Aggregates.ProductAggregate;

namespace VHElegantAttire.Infra.Data.Features.ProductCrud.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        }
        public Task<Product> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
