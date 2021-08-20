using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace Stopify.Services.Models
{
    public class WebShopUserServiceModel : IdentityUser, IMapFrom<WebShopUser>
    {
        public string FullName { get; set; }

        public List<OrderServiceModel> Orders { get; set; }
    }
}
