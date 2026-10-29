using AjayEmployeeManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AjayEmployeeManager.Controllers;
public class HomeController(AppDbContext db) : Controller {
 public async Task<IActionResult> Index() { ViewBag.Count = await db.Employees.CountAsync(); ViewBag.Departments = await db.Employees.Select(e=>e.Department).Distinct().CountAsync(); return View(); }
 public IActionResult Error() => View();
}
