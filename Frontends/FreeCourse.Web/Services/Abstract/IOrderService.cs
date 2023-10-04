using FreeCourse.Web.Models.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IOrderService
    {
        //sync
        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput);

        //async with RabbitMQ
        Task<OrderSuspendViewModel> SuspendOrder(CheckoutInfoInput checkoutInfoInput);

        Task<List<OrderViewModel>> GetOrder();
    }
}
