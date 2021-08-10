

using TechnoWebShop.Services.Models;
using System.Linq;
using System.Threading.Tasks;
using TechnoWebShop.Data.Models;


namespace TechnoWebShop.Services
{
    public interface IOrderService
    {
        Task<bool> CreateOrder(OrderServiceModel orderServiceModel);

        IQueryable<OrderServiceModel> GetAll();

        Task SetOrdersToReceipt(Receipt receipt);

        Task<bool> CompleteOrder(string orderId);

        Task<bool> ReduceQuantity(string orderId);

        Task<bool> IncreaseQuantity(string orderId);
    }
}
