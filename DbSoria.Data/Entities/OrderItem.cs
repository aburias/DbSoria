using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Guid? VariationPriceId { get; set; }
        [ForeignKey("VariationPriceId")]
        public ProductVariationPrice VariationPrice { get; set; }
        public ICollection<OrderAddOn> AddOns { get; set; }
        public decimal ItemPrice { get; set; }
    }
}