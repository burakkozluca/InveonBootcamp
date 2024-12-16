using LibraryProject.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LibraryProject.Controllers;

public class RoleController : Controller
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<IdentityUser> _userManager;
    
    public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(string roleName)
    {
        var result = await _roleManager.CreateAsync(new IdentityRole(roleName));
        
        if (result.Succeeded)
        {
            return RedirectToAction("ListRoles");
        }
        
        return View("Error");
    }
    
    [HttpGet]
    public IActionResult ListRoles()
    {
        var roles = _roleManager.Roles.ToList();
        return View(roles);
    }
    
    [HttpGet]
    public IActionResult AddUserToRole()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> AddUserToRole(string userId, string roleName)
    {
        var user = await _userManager.FindByIdAsync(userId);
        
        if (user == null)
        {
            return View("Error");
        }
        
        var result = await _userManager.AddToRoleAsync(user, roleName);
        
        if (result.Succeeded)
        {
            return RedirectToAction("ListRoles");
        }
        
        return View("Error");
    }
    
    [HttpGet]
    public IActionResult RemoveUserFromRole()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> RemoveUserFromRole(string userId, string roleName)
    {
        var user = await _userManager.FindByIdAsync(userId);
        
        if (user == null)
        {
            return View("Error");
        }
        
        var result = await _userManager.RemoveFromRoleAsync(user, roleName);
        
        if (result.Succeeded)
        {
            return RedirectToAction("ListRoles");
        }
        
        return View("Error");
    }
    
    [HttpGet]
    public IActionResult DeleteRole()
    {
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> DeleteRole(string id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }

        return View(role);
    }

    [HttpPost, ActionName("DeleteRole")]
    public async Task<IActionResult> DeleteRoleConfirmed(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }

        var result = await _roleManager.DeleteAsync(role);
        if (result.Succeeded)
        {
            return RedirectToAction("ListRoles");
        }

        return View(role);
    }

    
    [HttpGet]
    public IActionResult UpdateRole()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> UpdateRole(string roleName, string newRoleName)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        
        if (role == null)
        {
            return View("Error");
        }
        
        role.Name = newRoleName;
        
        var result = await _roleManager.UpdateAsync(role);
        
        if (result.Succeeded)
        {
            return RedirectToAction("ListRoles");
        }

        return View("Error");
    }

}