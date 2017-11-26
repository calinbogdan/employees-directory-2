using Microsoft.AspNetCore.Mvc;
using web_app.Data;
using web_app.Models;

namespace web_app.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesController(IEmployeesRepository employeesRepository) 
        {
            _employeesRepository = employeesRepository;
        } 

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeesRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            _employeesRepository.Add(employee);
            return Created($"/employees/{employee.Id}", employee);
        }
    }
}