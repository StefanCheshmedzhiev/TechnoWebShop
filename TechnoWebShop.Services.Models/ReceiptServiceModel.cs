
using System;
using System.Collections.Generic;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;


namespace TechnoWebShop.Services.Models
{
    public class ReceiptServiceModel : IMapFrom<Receipt>
    {
        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public List<OrderServiceModel> Orders { get; set; }

        public string RecipientId { get; set; }

        public WebShopUserServiceModel Recipient { get; set; }
    }
}
