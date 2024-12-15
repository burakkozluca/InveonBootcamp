using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibraryProject.Models;
using LibraryProject.Repositories.Books;

namespace LibraryProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBookRepository _bookRepository;

    public HomeController(ILogger<HomeController> logger,IBookRepository bookRepository)
    {
        _logger = logger;
        _bookRepository = bookRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Book()
    {
        var books = _bookRepository.GetAll();
        return View(books);
    }
    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}