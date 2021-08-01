
using System;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace Stopify.Web.ViewModels.Product.Delete
{
    public class ProductDeleteViewModel : IMapFrom<ProductServiceModel>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime ManufacturedOn { get; set; }

        public string Picture { get; set; }

        public ProductDeleteProductTypeViewModel ProductType { get; set; }
    }
}
