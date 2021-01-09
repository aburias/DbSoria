using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class StoreInvite : BaseEntity
    {
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public Guid InvitedSellerId { get; set; }
        [ForeignKey("InvitedSellerId")]
        public Seller InvitedSeller { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsDeclined { get; set; }
    }
}