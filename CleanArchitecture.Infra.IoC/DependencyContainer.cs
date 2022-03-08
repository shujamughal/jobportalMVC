using CleanArchitectiiure.Application.Services.JobProviderServices;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Interfaces.JobProviderInterfaces;
using CleanArchitecture.Application.Services;
using CoreCleanAcrhictecture.Domain.Interfaces;
using CoreCleanAcrhictecture.Domain.Interfaces.JobProviderRepoInterfaces;
using CoreCleanArchitecture.Infrastructure.Data.Repositories;
using CoreCleanArchitecture.Infrastructure.Data.Repositories.JobProviderRepository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
/*            services.AddScoped<IJobSeekerService, JobSeekerService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();
*/
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped<IJobSeekerService, JobSeekerService>();
            services.AddScoped<ISkillsService, SkillsService>();
            services.AddScoped<ICitiesService, CitiesService>();


            //JobProviderService_&_Repository
            services.AddScoped<IJobProviderService, JobProviderService>();            
            services.AddTransient<IJobProviderRepository, JobProviderRepository>();

            services.AddTransient<ICRUDDbHelperRepository, CRUDDbHelperRepository>();
            services.AddTransient<ICitiesRepository, CitiesRepository>();
            services.AddTransient<IJobSeekerRepository, JobSeekerRepository>();
            services.AddTransient<IJobSeekerRolesRepository, JobSeekerRolesRepository>();
            services.AddTransient<IJobSeekerSkillsRepository, JobSeekerSkillsRepository>();
            services.AddTransient<ISkillsInfoRepository, SkillsRepository>();
            services.AddTransient<IRolesInfoRepository, RolesRepository>();
            services.AddTransient<IEducationInstituteInfoRepository, EducationInstituteRepository>();
            services.AddTransient<ILanguageInfoRepository, LanguageRepository>();
        }

    }
}
