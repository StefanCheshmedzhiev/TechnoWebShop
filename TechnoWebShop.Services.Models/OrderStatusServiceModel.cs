
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;

namespace TechnoWebShop.Services.Models
{
    public class OrderStatusServiceModel : IMapFrom<OrderStatus>
    {
        public string Name { get; set; }
    }
}
