using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class StoreStaff : BaseEntity
    {
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public Guid SellerId { get; set; }
        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
        public ICollection<AccessPermision> Permissions { get; set; }
    }
}