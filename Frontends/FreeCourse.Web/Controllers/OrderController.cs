﻿using FreeCourse.Web.Models.Orders;
using FreeCourse.Web.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FreeCourse.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;

        public OrderController(IBasketService basketService, IOrderService orderService)
        {
            _basketService = basketService;
            _orderService = orderService;
        }

        public async Task<IActionResult> Checkout()
        {
            var basket = await _basketService.Get();

            ViewBag.basket = basket;
            return View(new CheckoutInfoInput());
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutInfoInput checkoutInfoInput)
        {
            //-- sync
            //var orderStatus = await _orderService.CreateOrder(checkoutInfoInput);

            //-- async -- rabbitmq
            var orderSuspend = await _orderService.SuspendOrder(checkoutInfoInput);

            if (!orderSuspend.IsSuccessful)
            {
                var basket = await _basketService.Get();

                ViewBag.basket = basket;
                ViewBag.error = orderSuspend.Error;

                return View();
            }
            //-- sync
            //return RedirectToAction(nameof(SuccessfulCheckout), new { orderId = orderStatus.OrderId });

            //-- async
            return RedirectToAction(nameof(SuccessfulCheckout), new { orderId = new Random().Next(1, 100000) });
        }

        public IActionResult SuccessfulCheckout(int orderId)
        {
            ViewBag.orderId = orderId;
            return View();
        }
    }
}
