using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductVariation : BaseEntity
    {
        public Guid ProductVariationGroupId { get; set; }
        [ForeignKey("ProductVariationGroupId")]
        public ProductVariationGroup ProductVariationGroup { get; set; }
        public string Name { get; set; }
        public Guid? ImageId { get; set; }
        public File Image { get; set; }
    }
}