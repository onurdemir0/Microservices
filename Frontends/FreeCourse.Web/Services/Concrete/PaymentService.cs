using FreeCourse.Web.Models.FakePayments;
using FreeCourse.Web.Services.Abstract;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> ReceivePayment(PaymentInfoInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}
