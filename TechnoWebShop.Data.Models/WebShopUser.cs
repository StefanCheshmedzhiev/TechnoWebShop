using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;




namespace TechnoWebShop.Data.Models
{
    public class WebShopUser : IdentityUser
    {
        public WebShopUser()
        {
            this.Orders = new List<Order>();
        }

        public string FullName { get; set; }

        public List<Order> Orders { get; set; }
    }
}
