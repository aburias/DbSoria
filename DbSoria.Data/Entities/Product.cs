using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class Product : BaseEntity
    {
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public string Name { get; set; }
        public bool IsAddOn { get; set; }
        public int Stocks { get; set; }
        public string ProductCode { get; set; }
        public double? Price { get; set; }
        public double? DiscountedPrice { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public Guid TemplateId { get; set; }
        [ForeignKey("TemplateId")]
        public Template Template { get; set; }
        public ICollection<ProductSection> Sections { get; set; }
        public ICollection<ProductVariationGroup> VariationGroups { get; set; }
        public ICollection<ProductVariationPrice> VariationPrices { get; set; }
        [InverseProperty("AddOnProduct")]
        public ICollection<ProductAddOn> ProductAddOns { get; set; }
    }
}