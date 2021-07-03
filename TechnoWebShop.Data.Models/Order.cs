﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechnoWebShop.Data.Models
{
    public class Order : BaseModel<string>
    {
        public DateTime IssuedOn { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public string IssuerId { get; set; }

        public WebShopUser Issuer { get; set; }

        public int StatusId { get; set; }

        public OrderStatus Status { get; set; }
    }
}
