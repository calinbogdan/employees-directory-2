using System.Collections.Generic;
using web_app.Models;

namespace web_app.Data
{
    public interface IEmployeesRepository
    {
         IEnumerable<Employee> GetAll();
         Employee Get(int id);
         void Add(Employee employee);
         void Delete(int id);
         void Update(int id, Employee employee);
    }
}