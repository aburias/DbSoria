using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class OrderPaymentDetail : BaseEntity
    {
        public Guid OrderId { get; set; }
        [ForeignKey("OrderId")]
        public OrderItem Order { get; set; }
        public bool IsPaid { get; set; }
        public PaymentType PaymentType { get; set; }
        public bool PaymentVerified { get; set; }

    }

    public enum PaymentType
    {
        CashOnDelivery,
        BankTransfer,

    }
}