using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class AccessPermision : BaseEntity
    {
        public Guid StoreStaffId { get; set; }
        [ForeignKey("StoreStaffId")]
        public StoreStaff StoreStaff { get; set; }
        public Guid PermissionId { get; set; }
        [ForeignKey("PermissionId")]
        public Permission Permission { get; set; }
    }
}