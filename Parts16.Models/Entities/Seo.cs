using System.ComponentModel.DataAnnotations.Schema;
using Parts16.Models.Common;

namespace Parts16.Models.Entities
{
    [Table(name: "Seo")]
    public class Seo : BaseEntity
    {
        public string Title { get; set; }

        public string Keyword { get; set; }

        public string Description { get; set; }

        public WebMenu Menu { get; set; }

    }
}
