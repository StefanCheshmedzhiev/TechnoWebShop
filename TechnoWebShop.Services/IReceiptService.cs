
using System.Linq;
using System.Threading.Tasks;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Services
{
    public interface IReceiptService
    {
        Task<string> CreateReceipt(string recipientId);

        IQueryable<ReceiptServiceModel> GetAll();

        IQueryable<ReceiptServiceModel> GetAllByRecipientId(string recipientId);
    }
}
