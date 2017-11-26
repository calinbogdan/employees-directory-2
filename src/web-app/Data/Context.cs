using Microsoft.EntityFrameworkCore;

namespace web_app.Data
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}