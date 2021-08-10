using Stopify.Services.Models;
using System;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

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

        public StopifyUserServiceModel Issuer { get; set; }

        public int StatusId { get; set; }

        public OrderStatusServiceModel Status { get; set; }
    }
}
