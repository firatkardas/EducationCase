using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entitities
{
    
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid Id { get; set; }=Guid.NewGuid();
    }
}
