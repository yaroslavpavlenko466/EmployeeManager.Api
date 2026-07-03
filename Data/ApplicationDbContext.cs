using EmployeeManager.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManager.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }
}