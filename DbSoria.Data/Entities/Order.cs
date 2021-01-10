using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DbSoria.Data.Entities
{
    public class Order : BaseEntity
    {
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public Guid BuyerId { get; set; }
        [ForeignKey("BuyerId")]
        public Buyer Buyer { get; set; }
        public OrderStatus Status { get; set; }
        public int TotalItems => Items?.Count ?? 0;
        public decimal TotalPrice => Items?.Sum(i => i?.ItemPrice ?? 0) ?? 0;
        public ICollection<OrderItem> Items { get; set; }
    }

    public enum OrderStatus
    {
        Processing = 1,
        PaymentPending = 2,
        Shipped = 3,
        Cancelled = 4,
        Delivered = 5,
        Returned = 6,
        Completed = 7
    }
}