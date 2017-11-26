using System.Collections.Generic;
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
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}