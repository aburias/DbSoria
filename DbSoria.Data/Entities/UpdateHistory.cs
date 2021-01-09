using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class UpdateHistory : BaseEntity
    {
        public Guid ObjectId { get; set; }
        public DateTime LastUpdatedDateTimeUtc { get; set; }
        public Guid UpdatedById { get; set; }
        [ForeignKey("UpdatedById")]
        public Account UpdatedBy { get; set; }
        public string OriginalObject { get; set; }
        public string UpdatedObject { get; set; }
        public UpdateType Type { get; set; }
    }

    public enum UpdateType
    {
        Created = 1,
        Updated = 2,
        Deleted = 3
    }
}