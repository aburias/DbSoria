using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace DbSoria.Data.Entities
{
    public class Account : BaseEntity
    {
        public Account()
        {
            IsEmailVerified = false;
            IsPhoneVerified = false;
            IsAdmin = false;
            IsActive = false;
        }

        public bool IsAdmin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPhoneVerified { get; set; }
        public bool IsActive { get; set; }
        public AccountType AccountType { get; set; }
    }

    public enum AccountType
    {
        Seller = 1,
        Buyer = 2 // Implement Next
    }
}