using LibraryProject.Migrations;
using LibraryProject.Services.Books;
using Microsoft.AspNetCore.Identity;

namespace LibraryProject.Services.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IBookService, BookService>();
        
        //services.AddFluentValidationAutoValidation();
        
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        
        return services;
    }
}