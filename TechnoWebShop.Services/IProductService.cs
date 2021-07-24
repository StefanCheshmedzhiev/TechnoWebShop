using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Services
{
    public interface IProductService
    {
        Task<IQueryable<ProductTypeServiceModel>> GetAllProductTypes();
        Task<bool> Create(ProductServiceModel productServiceModel);

        Task<bool> CreateProductType(ProductTypeServiceModel productTypeServiceModel);
    }
}
