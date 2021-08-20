using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.InputModels
{
   public class ProductCreateInputModel : IMapTo<ProductServiceModel>, IHaveCustomMappings
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ManufacturedOn { get; set; }

        [Required]
        public IFormFile Picture { get; set; }

        [Required]
        public string ProductType { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<ProductCreateInputModel, ProductServiceModel>()
                .ForMember(destination => destination.ProductType,
                            opts => opts.MapFrom(origin => new ProductTypeServiceModel { Name = origin.ProductType }));
        }
    }
}
