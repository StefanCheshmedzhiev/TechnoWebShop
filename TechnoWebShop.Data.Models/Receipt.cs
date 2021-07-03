using System;
using System.Collections.Generic;
using System.Text;

namespace TechnoWebShop.Data.Models
{
    public class Receipt : BaseModel<string>
    {
        public Receipt()
        {
            this.Orders = new List<Order>();
        }

        public DateTime IssuedOn { get; set; }

        public List<Order> Orders { get; set; }

        public string RecipientId { get; set; }

        public WebShopUser Recipient { get; set; }
    }
}
