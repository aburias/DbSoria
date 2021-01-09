using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class Template : BaseEntity
    {
        public string Name { get; set; }
        public string Html { get; set; }
        public string Json { get; set; }

        public Guid TemplateTypeId { get; set; }
        [ForeignKey("TemplateTypeId")]
        public TemplateType TemplateType { get; set; }
        //public TemplateType TemplateType { get; set; }
    }

    //public enum TemplateType
    //{
    //    Product = 0,
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