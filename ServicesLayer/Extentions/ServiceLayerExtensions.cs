using DataAccessLayer.Repositories.Abstractions;
using DataAccessLayer.Repositories.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServicesLayer.Services.Abstractions;
using ServicesLayer.Services.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Extentions
{
    public static  class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtention(this IServiceCollection services)
        {

            services.AddScoped<IEducationService, EducationService>();
            return services;

        }
    }
}
