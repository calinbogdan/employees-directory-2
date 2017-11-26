using Microsoft.EntityFrameworkCore;
using web_app.Models;

namespace web_app.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }
    }
}