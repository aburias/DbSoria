using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductVariationGroup : BaseEntity
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductVariation> Variations { get; set; }
    }
}