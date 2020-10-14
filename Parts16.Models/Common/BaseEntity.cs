using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts16.Models.Common
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public DateTime UpdateTime { get; set; } = DateTime.Now;

        public bool IsRemoved { get; set; } = false;
    }
}
