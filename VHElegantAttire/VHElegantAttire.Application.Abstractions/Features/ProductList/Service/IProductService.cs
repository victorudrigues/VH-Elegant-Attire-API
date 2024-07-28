using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHElegantAttire.Application.Abstractions.Features.ProductList.Service
{
    public interface IProductService
    {
        Task ListProducts(int id);
    }
}
