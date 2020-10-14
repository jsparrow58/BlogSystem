using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Parts16.Models.Common;

namespace Parts16.Models.Entities
{
    public class Admin: BaseEntity
    {
        [Required, StringLength(50), Index("IX_Email_Unique", IsUnique = true)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string NickName { get; set; }

        public string Photo { get; set; }

        public Role Role { get; set; }

    }
}
