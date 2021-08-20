

using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.InputModels
{
    public class ProductOrderInputModel : IMapTo<OrderServiceModel>
    {
        public string ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
