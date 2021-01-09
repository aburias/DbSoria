using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedDateTimeUtc = DateTime.UtcNow;
            UpdatedDateTimeUtc = DateTime.UtcNow;
            IsDeleted = false;
        }

        public Guid Id { get; set; }
        public DateTime CreatedDateTimeUtc { get; set; }
        public DateTime UpdatedDateTimeUtc { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public Account CreatedBy { get; set; }
    }
}