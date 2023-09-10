using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entitities
{
    public class Education:BaseEntity
    {
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Instructor instructor { get; set; }
        public int limit { get; set; }
        [Column(TypeName = "decimal(18,4)")]

        public decimal cost { get; set; }
        public DateTime time { get; set; }
    }
}
