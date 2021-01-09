using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class AccessPermision : BaseEntity
    {
        public Guid AccessDetailId { get; set; }
        [ForeignKey("AccessDetailId")]
        public AccessDetail AccessDetail { get; set; }
        public Guid PermissionId { get; set; }
        [ForeignKey("PermissionId")]
        public Permission Permission { get; set; }
    }
}