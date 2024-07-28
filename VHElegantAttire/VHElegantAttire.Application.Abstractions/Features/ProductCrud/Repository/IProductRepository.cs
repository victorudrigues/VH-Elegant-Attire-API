using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Domain.Aggregates.ProductAggregate;

namespace VHElegantAttire.Application.Abstractions.Features.ProductCrud.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetById(string id);
    }
}
