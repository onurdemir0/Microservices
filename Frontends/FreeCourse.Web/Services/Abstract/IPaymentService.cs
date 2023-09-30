using FreeCourse.Web.Models.FakePayments;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IPaymentService
    {
        Task<bool> ReceivePayment(PaymentInfoInput input);
    }
}
