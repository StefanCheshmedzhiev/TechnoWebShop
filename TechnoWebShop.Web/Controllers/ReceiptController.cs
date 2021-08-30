using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TechnoWebShop.Services;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;
using TechnoWebShop.Web.ViewModels.Receipt.Details;
using TechnoWebShop.Web.ViewModels.Receipt.Profile;

namespace TechnoWebShop.Web.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly IReceiptService receiptService;

        public ReceiptController(IReceiptService receiptService)
        {
            this.receiptService = receiptService;
        }

        [HttpGet(Name = "Profile")]
        public async Task<IActionResult> Profile()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            List<ReceiptServiceModel> receiptsFromDb = await this.receiptService
                .GetAllByRecipientId(userId)
                .ToListAsync();

            List<ReceiptProfileViewModel> receiptsForCurrentUser = receiptsFromDb
                .Select(receipt => receipt.To<ReceiptProfileViewModel>()).ToList();

            return this.View(receiptsForCurrentUser);
        }

        [HttpGet(Name = "Details")]
        public async Task<IActionResult> Details(string id)
        {
            ReceiptServiceModel receiptServiceModel = await this.receiptService.GetAll()
                .SingleOrDefaultAsync(receipt => receipt.Id == id);

            ReceiptDetailsViewModel receiptDetailsViewModel = receiptServiceModel.To<ReceiptDetailsViewModel>();

            return this.View(receiptDetailsViewModel);
        }
    }
}