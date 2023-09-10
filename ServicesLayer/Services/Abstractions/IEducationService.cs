using EntityLayer.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services.Abstractions
{
    public interface IEducationService
    {
        Task<List<Education>> GetAllEducation();
    }
}
