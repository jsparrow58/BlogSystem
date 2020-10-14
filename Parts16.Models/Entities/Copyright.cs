using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Parts16.Models.Common;

namespace Parts16.Models.Entities
{
    [Table(name: "Copyright")]
    public class Copyright : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Detail { get; set; }
        public string Telephone { get; set; }
        public string Logo { get; set; }
        public string Images { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string QQ { get; set; }
        public string WeChat { get; set; }
    }
}
