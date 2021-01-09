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
        [InverseProperty("Staff")]
        public ICollection<Store> ManagedStores { get; set; }
        [InverseProperty("Owner")]
        public ICollection<Store> OwnedStores { get; set; }
        public ICollection<AccessDetail> AccessDetails { get; set; }
        public ICollection<StoreInvite> StoreInvites { get; set; }
    }
}