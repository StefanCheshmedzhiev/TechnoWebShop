using System;
using System.Collections.Generic;
using System.Text;

namespace TechnoWebShop.Data.Models
{
    public class OrderStatus : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
