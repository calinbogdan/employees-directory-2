using Microsoft.EntityFrameworkCore;
using web_app.Models;

namespace web_app.Data
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}