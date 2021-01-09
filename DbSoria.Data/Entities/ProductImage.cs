using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductImage : BaseEntity
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public Guid ImageId { get; set; }
        [ForeignKey("ImageId")]
        public File Image { get; set; }

    }
}