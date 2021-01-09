using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class Seller : BaseEntity
    {
        public Guid AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public ICollection<StoreStaff> ManagedStores { get; set; }
        public ICollection<Store> OwnedStores { get; set; }
        public ICollection<StoreInvite> StoreInvites { get; set; }
    }
}