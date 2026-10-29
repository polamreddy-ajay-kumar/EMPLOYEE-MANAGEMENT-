using AjayEmployeeManager.Data;
using AjayEmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AjayEmployeeManager.Controllers;
public class EmployeesController(AppDbContext db) : Controller {
 public async Task<IActionResult> Index(string? search) { ViewBag.Search=search; var q=db.Employees.AsQueryable(); if(!string.IsNullOrWhiteSpace(search)) q=q.Where(e=>e.Name.Contains(search)||e.Department.Contains(search)||e.Email.Contains(search)); return View(await q.OrderBy(e=>e.Name).ToListAsync()); }
 public IActionResult Create()=>View(new Employee());
 [HttpPost,ValidateAntiForgeryToken] public async Task<IActionResult> Create(Employee employee) { if(!ModelState.IsValid)return View(employee); db.Employees.Add(employee);await db.SaveChangesAsync();return RedirectToAction(nameof(Index)); }
 public async Task<IActionResult> Edit(int id) { var e=await db.Employees.FindAsync(id);return e==null?NotFound():View(e); }
 [HttpPost,ValidateAntiForgeryToken] public async Task<IActionResult> Edit(int id,Employee employee) { if(id!=employee.Id)return BadRequest(); if(!ModelState.IsValid)return View(employee); if(!await db.Employees.AnyAsync(e=>e.Id==id))return NotFound();db.Employees.Update(employee);await db.SaveChangesAsync();return RedirectToAction(nameof(Index)); }
 [HttpPost,ValidateAntiForgeryToken] public async Task<IActionResult> Delete(int id) { var e=await db.Employees.FindAsync(id);if(e!=null){db.Employees.Remove(e);await db.SaveChangesAsync();}return RedirectToAction(nameof(Index)); }
}
