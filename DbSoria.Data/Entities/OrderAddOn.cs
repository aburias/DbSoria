using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class OrderAddOn : BaseEntity
    {
        public Guid OrderItemId { get; set; }
        [ForeignKey("OrderItemId")]
        public OrderItem OrderItem { get; set; }
        public Guid ProductAddOnId { get; set; }
        [ForeignKey("ProductAddOnId")]
        public ProductAddOn ProductAddOn { get; set; }
    }
}