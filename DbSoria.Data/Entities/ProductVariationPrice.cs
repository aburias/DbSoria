using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductVariationPrice : BaseEntity
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public ICollection<ProductVariationPriceVariationId> VariationCombinations { get; set; }
    }
}