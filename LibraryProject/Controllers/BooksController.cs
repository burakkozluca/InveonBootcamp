using LibraryProject.Repositories.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers;

public class BooksController : Controller
{
    private readonly IBookRepository _bookRepository;
    
    public BooksController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    
    public IActionResult Book()
    {
        if (!User.Identity.IsAuthenticated)
        {
            // User/Login sayfasına yönlendirme
            return RedirectToAction("Login", "User");
        }
        var books = _bookRepository.GetAll();
        return View(books);
    }
    
    [Authorize]
    public async Task<IActionResult> Details(int id)
    {
        var book = await _bookRepository.GetByIdAsync(id); // ValueTask'ten gerçek sonucu alıyoruz.
        if (book == null)
        {
            return NotFound(); // Kitap bulunamazsa 404 döndür.
        }
        return View(book); // Kitap nesnesini View'e gönder.
    }
}