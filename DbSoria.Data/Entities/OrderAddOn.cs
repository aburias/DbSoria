using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class OrderAddOn : BaseEntity
    {
        public Guid OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public Guid ProductAddOnId { get; set; }
        [ForeignKey("ProductAddOnId")]
        public ProductAddOn ProductAddOn { get; set; }
    }
}