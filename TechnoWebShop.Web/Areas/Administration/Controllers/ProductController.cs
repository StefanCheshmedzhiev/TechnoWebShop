using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnoWebShop.Services;
using TechnoWebShop.Services.Models;
using TechnoWebShop.Web.InputModels;

namespace TechnoWebShop.Web.Areas.Administration.Controllers
{
    public class ProductController : AdminController
    {
        
        [HttpGet]
        [Route("/Type/Create")]
        public async Task<IActionResult> CreateType()
        {

            return this.View("Type/Create");
        }

        [HttpPost]
        [Route("/Type/Create")]
        public async Task<IActionResult> CreateType(ProductTypeCreateInputModel productTypeCreateInputModel)
        {
            ProductServiceModel productServiceModel = new ProductServiceModel
            {
                Name = productTypeCreateInputModel.Name
            };

            return this.Redirect("/");
        }

        [HttpGet(Name = "Create")]
        public async Task<IActionResult> Create()
        {

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateInputModel productCreateInputModel)
        {
            ProductServiceModel productServiceModel = new ProductServiceModel
            {
                Name = productCreateInputModel.Name,
                Price = productCreateInputModel.Price,
                ManufacturedOn = productCreateInputModel.ManufacturedOn,
                ProductType = new ProductTypeServiceModel
                { 
                  Name = productCreateInputModel.ProductType
                }
            };

            return this.Redirect("/");
        }
    }
}