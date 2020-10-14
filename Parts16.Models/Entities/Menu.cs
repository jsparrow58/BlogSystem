using System.ComponentModel.DataAnnotations;
using Parts16.Models.Common;

namespace Parts16.Models.Entities
{
    public class Menu : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Link { get; set; }

        public string Icon { get; set; }

        public Menu Parent { get; set; }
    }
}
