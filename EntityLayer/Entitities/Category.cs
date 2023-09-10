using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entitities
{
    public class Category:BaseEntity
    {
        public string online { get; set; }
        public string classroomTraining { get; set; }
        public string book { get; set; }
        public string presentation { get; set; }
        public string article { get; set; }
        public string miniProject { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
