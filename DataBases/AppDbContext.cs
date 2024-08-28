using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using myCrudC_.Models;
namespace myCrudC_.Database;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}