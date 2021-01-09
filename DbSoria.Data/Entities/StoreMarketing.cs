using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class StoreMarketing : BaseEntity
    {
        public StoreMarketing()
        {
            IsFacebookPixelEnabled = false;
        }

        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public string FacebookPixelId { get; set; }
        public bool IsFacebookPixelEnabled { get; set; }
    }
}