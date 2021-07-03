using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using IdentityUser = Microsoft.AspNet.Identity.EntityFramework.IdentityUser;

namespace TechnoWebShop.Data.Models
{
    public class WebShopUser : IdentityUser<string>
    {
        public WebShopUser()
        {
            this.Orders = new List<Order>();
        }

        public string FullName { get; set; }

        public List<Order> Orders { get; set; }
    }
}
