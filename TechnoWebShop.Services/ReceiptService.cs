using System;
using System.Linq;
using System.Threading.Tasks;
using Stopify.Services.Models;
using TechnoWebShop.Data;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services;
using TechnoWebShop.Services.Mapping;

namespace Stopify.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly TechnoWebShopDbContext context;

        private readonly IOrderService orderService;

        public ReceiptService(TechnoWebShopDbContext context, IOrderService orderService)
        {
            this.context = context;
            this.orderService = orderService;
        }

        public async Task<string> CreateReceipt(string recipientId)
        {
            Receipt receipt = new Receipt
            {
                IssuedOn = DateTime.UtcNow,
                RecipientId = recipientId
            };

            await this.orderService.SetOrdersToReceipt(receipt);

            foreach (var order in receipt.Orders)
            {
                await this.orderService.CompleteOrder(order.Id);
            }

            this.context.Receipts.Add(receipt);
            int result = await this.context.SaveChangesAsync();

            return receipt.Id;
        }

        public IQueryable<ReceiptServiceModel> GetAll()
        {
            return this.context.Receipts
                .To<ReceiptServiceModel>();
        }

        public IQueryable<ReceiptServiceModel> GetAllByRecipientId(string recipientId)
        {
            return this.context.Receipts
                .Where(receipt => receipt.RecipientId == recipientId)
                .To<ReceiptServiceModel>();
        }
    }
}
