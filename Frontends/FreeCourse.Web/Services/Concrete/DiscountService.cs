using FreeCourse.Web.Models.Discount;
using FreeCourse.Web.Services.Abstract;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class DiscountService : IDiscountService
    {
        public Task<DiscountViewModel> GetDiscount(string discountCode)
        {
            throw new System.NotImplementedException();
        }
    }
}
