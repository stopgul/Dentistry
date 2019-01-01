using Dentistry.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dentistry.EntityFramework
{
    public static class EntityFrameworkServiceCollectionExtensions
    {
        public static IServiceCollection AddDentistryEntityFramework(this IServiceCollection services)
        {
            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<DentistryDbContext>();

            return services;
        }
    }
}
