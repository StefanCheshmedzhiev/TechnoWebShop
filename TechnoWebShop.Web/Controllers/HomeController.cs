using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnoWebShop.Services;
using TechnoWebShop.Web.Models;
using TechnoWebShop.Web.ViewModels.Home.Index;

namespace TechnoWebShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index([FromQuery]string criteria = null)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                List<ProductHomeViewModel> products = await this.productService.GetAllProducts(criteria)
                    .Select(product => new ProductHomeViewModel
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Picture = product.Picture
                    })
                    .ToListAsync();

                this.ViewData["criteria"] = criteria;

                return this.View(products);
            }

            return View();
        }

    }
}
