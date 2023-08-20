using FreeCourse.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    //EF Core features
    //-- Owned types
    //-- Shadow property
    //-- Backing field
    public class Order : Entity, IAggregateRoot
    {
        public DateTime CreatedDate { get; private set; }
        public Address Address { get; private set; } //Owned entity type
        public string BuyerId { get; private set; }

        private readonly List<OrderItem> _orderItems; //Backing field

        public IReadOnlyCollection<OrderItem> OrderItems { get { return _orderItems; } }
        //public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order()
        {                
        }
        public Order(Address address, string buyerId)
        {
            Address = address;
            BuyerId = buyerId;
            _orderItems = new List<OrderItem>();
            CreatedDate = DateTime.Now;
        }

        public void AddOrderItem(string productId, string productName, decimal price, string pictureUrl)
        {
            var existProduct = _orderItems.Any(p => p.ProductId == productId);
            
            if (!existProduct)
                _orderItems.Add(new OrderItem(productId, productName, pictureUrl, price));
        }

        public decimal GetTotalPrice=> _orderItems.Sum(i => i.Price);
    }
}
