using System.Collections.Generic;
using System.Linq;
using web_app.Models;

namespace web_app.Data
{
    public class EmployeesRepository : IEmployeesRepository
    {

        private readonly Context _context;
        public EmployeesRepository(Context context)
        {
            _context = context;
        }
        
        public void Add(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee employeeToRemove = Get(id);
            _context.Remove(employeeToRemove);
            _context.SaveChanges();
        }

        public Employee Get(int id)
        {
            return _context.Employees.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public void Update(int id, Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}