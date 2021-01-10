using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductCategory : BaseEntity
    {
        public Guid? ParentCategoryId { get; set; }
        [ForeignKey("ParentCategoryId")]
        [InverseProperty("SubCategories")]
        public ProductCategory ParentCategory { get; set; }
        [InverseProperty("ParentCategory")]
        public ICollection<ProductCategory> SubCategories { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? BannerId { get; set; }
        [ForeignKey("BannerId")]
        public File Banner { get; set; }
    }
}