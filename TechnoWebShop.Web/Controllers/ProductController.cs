using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TechnoWebShop.Services;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;
using TechnoWebShop.Web.InputModels;
using TechnoWebShop.Web.ViewModels;

namespace TechnoWebShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        private readonly IOrderService orderService;

        public ProductController(IProductService productService, IOrderService orderService)
        {
            this.productService = productService;
            this.orderService = orderService;
        }

        [HttpGet(Name = "Details")]
        public async Task<IActionResult> Details(string id)
        {
            ProductDetailsViewModel productViewModel = (await this.productService.GetById(id))
                .To<ProductDetailsViewModel>();

            return View(productViewModel);
        }

        [HttpPost(Name = "Order")]
        public async Task<IActionResult> Order(ProductOrderInputModel productOrderInputModel)
        {
            OrderServiceModel orderServiceModel = productOrderInputModel.To<OrderServiceModel>();

            orderServiceModel.IssuerId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.orderService.CreateOrder(orderServiceModel);

            return this.Redirect("/");
        }
    }
}
