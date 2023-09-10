using DataAccessLayer.UnitOfworks;
using EntityLayer.Entitities;
using ServicesLayer.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services.Concete
{
    public class EducationService : IEducationService
    {
        private readonly IUnitOfWork unitOfWork;
        public EducationService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }
        public async Task<List<Education>> GetAllEducation( )
        {
            return await unitOfWork.GetRepository<Education>().GetAllAsync();
        }
    }
}
