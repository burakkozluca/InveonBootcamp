using LibraryProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers;

public class UserController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    
    public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    //Kullanıcı Ekleme (Create)
    [HttpPost]
    public async Task<IActionResult> Create(string email, string password)
    {
        var user = new IdentityUser
        {
            UserName = email,
            Email = email
        };
        
        var result = await _userManager.CreateAsync(user, password);
        
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }
        
        return RedirectToAction("Index", "Home");
    }
    
    //Kullanıcıları listeleme
    [HttpGet]
    public IActionResult ListUsers()
    {
        var users = _userManager.Users.ToList();
        return View(users);
    }
    
    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }
    
    //Kullanıcı Update
    [HttpPost]
    public async Task<IActionResult> Update(string id, string email, string password)
    {
        var user = await _userManager.FindByIdAsync(id);
        
        if (user == null)
        {
            return RedirectToAction("Index", "Home");
        }
        
        user.Email = email;
        user.UserName = email;
        
        var result = await _userManager.UpdateAsync(user);
        
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }
        
        return RedirectToAction("Index", "Home");
    }
    
    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }
    //Kullanıcı Silme
    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        
        if (user == null)
        {
            return RedirectToAction("Index", "Home");
        }
        
        var result = await _userManager.DeleteAsync(user);
        
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }
        
        return RedirectToAction("Index", "Home");
    }
    
    [AllowAnonymous]
    public IActionResult Register()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email
            };
            
            var result = await _userManager.CreateAsync(user, model.Password);
            
            if (result.Succeeded)
            {
                // Kullanıcıyı sisteme giriş yapmış gibi kaydet
                //await _signInManager.SignInAsync(user, isPersistent: false);
    
                // Kayıt işlemi tamamlandıktan sonra login sayfasına yönlendir
                return RedirectToAction("Login", "User");
            }
            
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
        
        return View(model);
    }

    
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _userManager.FindByEmailAsync(model.Email);
            
            if (result != null)
            {
                var signInResult = await _userManager.CheckPasswordAsync(result, model.Password);
                
                if (signInResult)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        
        ModelState.AddModelError("", "Invalid login attempt");
        return View(model);
    }
}