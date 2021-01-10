using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class Order : BaseEntity
    {
        public Guid BuyerId { get; set; }
        [ForeignKey("BuyerId")]
        public Buyer Buyer { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Guid? VariationPriceId { get; set; }
        [ForeignKey("VariationPriceId")]
        public ProductVariationPrice VariationPrice { get; set; }
        public ICollection<OrderAddOn> AddOns { get; set; }
    }
}