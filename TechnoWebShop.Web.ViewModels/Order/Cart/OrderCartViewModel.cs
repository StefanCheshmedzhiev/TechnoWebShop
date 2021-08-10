

using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.ViewModels.Order.Cart
{
    public class OrderCartViewModel : IMapFrom<OrderServiceModel>
    {
        public string Id { get; set; }

        public string ProductPicture { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }
}
