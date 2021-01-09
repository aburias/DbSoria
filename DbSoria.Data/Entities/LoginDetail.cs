using System.ComponentModel.DataAnnotations.Schema;

namespace DbSoria.Data.Entities
{
    public class LoginDetail : BaseEntity
    {
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}