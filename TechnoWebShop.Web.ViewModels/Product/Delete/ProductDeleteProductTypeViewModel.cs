

using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace Stopify.Web.ViewModels.Product.Delete
{
    public class ProductDeleteProductTypeViewModel : IMapFrom<ProductTypeServiceModel>
    {
        public string Name { get; set; }
    }
}