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
        public string Currency { get; set; }
        public string SubDomain => Name.ToSubDomain();
        public Guid OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public Seller Owner { get; set; }
        public ICollection<StoreStaff> Staff { get; set; }
        public ICollection<StoreInvite> StoreInvites { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<StoreMarketing> StoreMarketings { get; set; }
    }
}