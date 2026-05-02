using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public interface IProductsQuery
    {
        public Task<List<Product>> GetAllProducts();
        public Task<Product> GetProductById(Guid id);
    }
}
