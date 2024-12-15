using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LibraryProject.Repositories;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BookLibrary;User Id=sa;Password=BEB-Lti123.;TrustServerCertificate=True;Encrypt=False");

        return new AppDbContext(optionsBuilder.Options);
    }
}
