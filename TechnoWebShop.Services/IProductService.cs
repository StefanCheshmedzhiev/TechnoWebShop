using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Services
{
    public interface IProductService
    {
        Task<bool> Create(ProductServiceModel productServiceModel);

        Task<bool> CreateProductType(ProductTypeServiceModel productTypeServiceModel);
    }
}
