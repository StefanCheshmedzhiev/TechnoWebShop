using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnoWebShop.Services;
using TechnoWebShop.Services.Models;
using TechnoWebShop.Web.InputModels;
using TechnoWebShop.Web.ViewModels;

namespace TechnoWebShop.Web.Areas.Administration.Controllers
{
    public class ProductController : AdminController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;

        }

        [HttpGet]
        [Route("/Administration/Product/Type/Create")]
        public async Task<IActionResult> CreateType()
        {

            return this.View("Type/Create");
        }

        [HttpPost]
        [Route("/Administration/Product/Type/Create")]
        public async Task<IActionResult> CreateType(ProductTypeCreateInputModel productTypeCreateInputModel)
        {
            ProductTypeServiceModel productTypeServiceModel = new ProductTypeServiceModel
            {
                Name = productTypeCreateInputModel.Name
            };

            await this.productService.CreateProductType(productTypeServiceModel);

            return this.Redirect("/");
        }

        [HttpGet(Name = "Create")]
        public async Task<IActionResult> Create()
        {
            var allProductTypes = await this.productService.GetAllProductTypes();

            this.ViewData["types"] = allProductTypes.Select(productType => new ProductCreateProductTypeViewModel
            {
                Name = productType.Name
            })
                 .ToList();

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
            await this.productService.Create(productServiceModel);
            return this.Redirect("/");
        }
    }
}