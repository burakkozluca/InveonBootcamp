namespace LibraryProject.Repositories.Books;

public class BookRepository(AppDbContext context) : GenericRepository<Book>(context), IBookRepository
{
    
}