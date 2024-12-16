using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class AdminController : Controller
{
    public IActionResult AdminPanel()
    {
        if (User.IsInRole("Admin"))
        {
            return View();
        }

        // Admin olmayan kullanıcılar için yönlendirme
        return RedirectToAction("Index", "Home");
    }
}
