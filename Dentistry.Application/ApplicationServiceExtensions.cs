using AutoMapper;
using Dentistry.Application.Dentist;
using Dentistry.Application.Patient;
using Microsoft.Extensions.DependencyInjection;

namespace Dentistry.Application
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddDentistryApplication(this IServiceCollection services)
        {
            services.AddAutoMapper();

            //todo: add conventional registrar
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IDentistService, DentistService>();

            return services;
        }
    }
}
