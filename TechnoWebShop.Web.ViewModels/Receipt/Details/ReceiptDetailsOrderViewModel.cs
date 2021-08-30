
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.ViewModels.Receipt.Details
{
    public class ReceiptDetailsOrderViewModel : IMapFrom<OrderServiceModel>
    {
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }
    }
}
