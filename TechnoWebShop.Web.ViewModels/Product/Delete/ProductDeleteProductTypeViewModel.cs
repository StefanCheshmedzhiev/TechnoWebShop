

using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.ViewModels.Product.Delete
{
    public class ProductDeleteProductTypeViewModel : IMapFrom<ProductTypeServiceModel>
    {
        public string Name { get; set; }
    }
}