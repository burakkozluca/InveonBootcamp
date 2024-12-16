using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibraryProject.Models;
using LibraryProject.Repositories.Books;
using Microsoft.AspNetCore.Authorization;

namespace LibraryProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        if (!User.Identity.IsAuthenticated)
        {
            // Giriş yapılmamışsa login sayfasına yönlendir
            return RedirectToAction("Login", "User");
        }
        return View();
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