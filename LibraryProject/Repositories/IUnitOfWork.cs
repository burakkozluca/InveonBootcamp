namespace LibraryProject.Repositories;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}