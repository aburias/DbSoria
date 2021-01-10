using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductAddOn : BaseEntity
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public Guid AddOnProductId { get; set; }
        [InverseProperty("ProductAddOns")]
        [ForeignKey("AddOnProductId")]
        public Product AddOnProduct { get; set; }
    }
}