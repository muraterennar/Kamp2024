using Application.CategortServices;
using Application.CourseServices;
using Application.InstructorServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationRegistrationService
{
    public static IServiceCollection AddApplicationService (this IServiceCollection services)
    {
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IInstructorService, InstructorService>();

        return services;
    }
}