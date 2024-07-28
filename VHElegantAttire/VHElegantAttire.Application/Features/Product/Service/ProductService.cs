using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Application.Abstractions.Features.ProductList.Service;

namespace VHElegantAttire.Application.Features.Product.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public Task ListProducts(int id)
        {
            throw new NotImplementedException();
        }
    }
}
