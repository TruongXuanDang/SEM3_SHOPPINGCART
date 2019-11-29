using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo002.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string MemberId { get; set; }
        public int PaymentTypeId { get; set; }
        public double TotalPrice { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhone { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order(string memberId, int paymentTypeId, double totalPrice, string shipName, string shipAddress, string shipPhone, DateTime createdAt, DateTime updatedAt, DateTime deletedAt, int status)
        {
            MemberId = memberId;
            PaymentTypeId = paymentTypeId;
            TotalPrice = totalPrice;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipPhone = shipPhone;
            CreatedAt = createdAt!=null?createdAt:DateTime.Now;
            UpdatedAt = updatedAt!=null?updatedAt:DateTime.Now;
            DeletedAt = deletedAt!=null?deletedAt:DateTime.Now;
            Status = status!=0?status:1;
        }

        public Order()
        {

        }
    }
}