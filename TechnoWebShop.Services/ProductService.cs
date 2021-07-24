using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoWebShop.Data;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Services
{
    public class ProductService : IProductService
    {
        private readonly TechnoWebShopDbContext context;

        public ProductService(TechnoWebShopDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> Create(ProductServiceModel productServiceModel)
        {
            Product product = new Product
            {
                Name = productServiceModel.Name,
                Price = productServiceModel.Price,
                ManufacturedOn = productServiceModel.ManufacturedOn
            };

            context.Products.Add(product);
           int result = await context.SaveChangesAsync();

            return result > 0;


        }

        public async Task<bool> CreateProductType(ProductTypeServiceModel productTypeServiceModel)
        {
            ProductType productType = new ProductType
            {
                Name = productTypeServiceModel.Name
            };
            context.ProductTypes.Add(productType);
            int result = await context.SaveChangesAsync();

            return result > 0;
        }

        public async Task <IQueryable<ProductTypeServiceModel>> GetAllProductTypes()
        {
            return  this.context.ProductTypes
                .Select(productType => new ProductTypeServiceModel
                {
                    Id = productType.Id,
                    Name = productType.Name
                });
                
        }
    }
}
