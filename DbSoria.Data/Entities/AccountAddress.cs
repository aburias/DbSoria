using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class AccountAddress : BaseEntity
    {
        public Guid AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        public Guid AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        public bool IsDefaultAddress { get; set; }
        public AddressType AddressType { get; set; }
    }

    public enum AddressType
    {
        Home = 1,
        Shipping = 2,
        Billing = 4
    }
}