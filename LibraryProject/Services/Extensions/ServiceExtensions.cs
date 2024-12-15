using LibraryProject.Services.Books;

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