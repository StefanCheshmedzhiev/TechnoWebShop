using System;
using System.Collections.Generic;
using System.Text;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;

namespace TechnoWebShop.Services.Models
{
    public class ProductTypeServiceModel : IMapFrom<ProductType>, IMapTo<ProductType>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

