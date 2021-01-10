using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class ProductSection : BaseEntity
    {
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public Guid TemplateId { get; set; }
        [ForeignKey("TemplateId")]
        public Template Template { get; set; }
        public Guid SectionTypeId { get; set; }
        [ForeignKey("SectionTypeId")]
        public ProductSectionType SectionType { get; set; }
        //public SectionType SectionType { get; set; }
    }

    //public enum SectionType
    //{
    //    RichText = 1,
    //    SaleEnds = 2,
    //    PaymentInfo = 3,
    //    Video = 4,
    //    RecentlyBought = 5,
    //    SocialMediaLinks = 6,
    //    ReviewsAndTestimonials = 7,
    //    RelatedProducts = 8,
    //    ImageList = 9
    //}
}