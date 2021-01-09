using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DbSoria.Helpers.Extensions;

namespace DbSoria.Data.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string SubDomain => Name.ToSubDomain();
        public Guid OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        [InverseProperty("OwnedStores")]
        public Seller Owner { get; set; }
        [InverseProperty("ManagedStores")]
        public ICollection<Seller> Staff { get; set; }
        public ICollection<AccessDetail> AccessDetails { get; set; }
        public ICollection<StoreInvite> StoreInvites { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}