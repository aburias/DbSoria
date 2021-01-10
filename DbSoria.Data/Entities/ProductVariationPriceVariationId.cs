using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductVariationPriceVariationId : BaseEntity
    {
        public Guid ProductVariationId { get; set; }
        [ForeignKey("ProductVariationId")]
        public ProductVariation ProductVariation { get; set; }

        public Guid ProductVariationPriceId { get; set; }
        [ForeignKey("ProductVariationPriceId")]
        public ProductVariationPrice ProductVariationPrice { get; set; }
        
    }
}