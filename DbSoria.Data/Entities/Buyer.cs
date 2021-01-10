using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class Buyer : BaseEntity
    {
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public Guid AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}