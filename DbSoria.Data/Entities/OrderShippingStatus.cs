using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class OrderShippingStatus : BaseEntity
    {
        public Guid OrderId { get; set; }
        [ForeignKey("OrderId")]
        public OrderItem Order { get; set; }
        public string LocationStatus { get; set; }
    }
}