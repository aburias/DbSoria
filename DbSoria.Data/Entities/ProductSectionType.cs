using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductSectionType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TemplateId { get; set; }
        [ForeignKey("TemplateId")]
        public Template Template { get; set; }
    }
}