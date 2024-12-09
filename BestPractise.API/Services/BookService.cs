using System.Xml.Linq;
using BestPractise.API.Model;

namespace BestPractise.API.Services;

public class BookService
{
    private readonly List<Book> _books;

    public BookService()
    {
        // Deneme verisi
        _books = Enumerable.Range(1, 100)
            .Select(i => new Book { Id = i, Title = $"Book {i}", Author = $"Author {i}" })
            .ToList();
    }
    
    public IEnumerable<Book> GetBooks(int pageNumber, int pageSize)
    {
        return _books.Skip((pageNumber - 1) * pageSize).Take(pageSize);
    }

    public Book GetBookById(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public void AddBook(Book newBook)
    {
        newBook.Id = _books.Max(b => b.Id) + 1;
        _books.Add(newBook);
    }

    public Book UpdateBook(int id, Book updatedBook)
    {
        var existingBook = _books.FirstOrDefault(b => b.Id == id);
        if (existingBook == null) return null;

        existingBook.Title = updatedBook.Title;
        existingBook.Author = updatedBook.Author;
        return existingBook;
    }

    public bool DeleteBook(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book == null) return false;

        _books.Remove(book);
        return true;
    }
}