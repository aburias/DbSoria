using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class AccessDetail : BaseEntity
    {
        public Guid SellerId { get; set; }
        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        [InverseProperty("AccessDetail")]
        public ICollection<AccessPermision> Permissions { get; set; }
    }
}