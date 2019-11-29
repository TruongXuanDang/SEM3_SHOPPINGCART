using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo002.Models;

namespace Demo002.Service
{
    public class OrderService: IOrderService
    {
        private Demo002Context db = new Demo002Context();

        public bool createOrder(ShoppingCart cart)
        {
            List<OrderDetail> _orderDetails = new List<OrderDetail>();
            
            // chuyển sang order, với từng cart item chuyển thành một order detail tương ứng và
            // save tất cả trong một transaction: begin traction, commit, rollback


            foreach(CartItem cartItem in cart.GetCartItems())
            {
                var orderDetail = new OrderDetail(cartItem.Quantity,cartItem.UnitPrice,cartItem.ProductId);
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                _orderDetails.Add(orderDetail);
            }
            Order order = new Order() { OrderDetails =  _orderDetails.ToList() };
            db.Orders.Add(order);
            db.SaveChanges();
            //int quantity, double unitPrice, int productId, int orderId, Product product, Order order
            throw new NotImplementedException();
        }
    }
}