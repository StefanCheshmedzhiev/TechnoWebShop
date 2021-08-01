using System;
using System.Collections.Generic;
using System.Text;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;

namespace TechnoWebShop.Services.Models
{
    public class ProductServiceModel : IMapFrom<Product>, IMapTo<Product>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int ProductTypeId { get; set; }

        public ProductTypeServiceModel ProductType { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public DateTime ManufacturedOn { get; set; }
    }
}
