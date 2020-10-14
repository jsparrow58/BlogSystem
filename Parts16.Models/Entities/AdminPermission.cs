using System.ComponentModel.DataAnnotations;
using Parts16.Models.Common;

namespace Parts16.Models.Entities
{
    public class AdminPermission: BaseEntity
    {
        [Required]
        public Role Role { get; set; }
        [Required]
        public Menu Menu { get; set; }
    }
}
