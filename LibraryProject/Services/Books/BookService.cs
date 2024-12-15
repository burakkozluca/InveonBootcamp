using LibraryProject.Repositories;
using LibraryProject.Repositories.Books;

namespace LibraryProject.Services.Books;

public class BookService(IBookRepository bookRepository, IUnitOfWork unitOfWork) : IBookService
{
    
}