using RentalPortal.Data.Requests;
using System.Threading.Tasks;

namespace RentalPortal.Service.Contract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
