using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entitities
{
    public class Instructor:BaseEntity
    {
        public string innerTrainer { get; set; }
        public string externalTrainer { get; set; }
    }
}
