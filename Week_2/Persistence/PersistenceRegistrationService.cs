using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories.CategoryRepository;
using Persistence.Repositories.CourseRepository;
using Persistence.Repositories.InstructorRepository;

namespace Persistence;

public static class PersistenceRegistrationService
{
    public static IServiceCollection AddPersistenceService (this IServiceCollection services)
    {
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IInstructorRepository, InstructorRepository>();


        return services;
    }
}