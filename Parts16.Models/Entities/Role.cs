using System.ComponentModel.DataAnnotations;
using Parts16.Models.Common;

namespace Parts16.Models.Entities
{
    public class Role : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }

    }
}
