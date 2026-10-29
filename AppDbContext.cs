using AjayEmployeeManager.Models;
using Microsoft.EntityFrameworkCore;
namespace AjayEmployeeManager.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) { public DbSet<Employee> Employees => Set<Employee>(); }
