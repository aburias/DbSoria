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
        public double? Price { get; set; }
        public double? DiscountedPrice { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductImage> Images { get; set; }
        public Guid TemplateId { get; set; }
        [ForeignKey("TemplateId")]
        public Template Template { get; set; }
        public ICollection<ProductSection> Sections { get; set; }
    }
}