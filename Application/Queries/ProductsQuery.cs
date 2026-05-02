using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class ProductsQuery: IProductsQuery
    {
        private readonly IProductRepository _repository;

        public ProductsQuery(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Product?> GetProductById(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
