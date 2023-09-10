using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstractions;
using DataAccessLayer.Repositories.Concrete;
using DataAccessLayer.UnitOfworks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Extentions
{
    public static class DataLayerExtentions
    {

        public static IServiceCollection LoadDataLayerExtention(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer("Server=.;Database=CASEDb;Trusted_Connection=true;Encrypt=False"));
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;

        }
    }
}
