using TechnoWebShop.Services.Models;
using System;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;
using Stopify.Services.Models;

namespace TechnoWebShop.Services.Models
{
    public class OrderServiceModel : IMapTo<Order>, IMapFrom<Order>
    {
        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public string ProductId { get; set; }

        public ProductServiceModel Product { get; set; }

        public int Quantity { get; set; }

        public string IssuerId { get; set; }

        public WebShopUserServiceModel Issuer { get; set; }

        public int StatusId { get; set; }

        public OrderStatusServiceModel Status { get; set; }
    }
}
