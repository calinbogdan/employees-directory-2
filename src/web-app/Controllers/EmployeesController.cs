using Microsoft.AspNetCore.Mvc;
using web_app.Data;

namespace web_app.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly EmployeesRepository _employeesRepository;
        public EmployeesController(EmployeesRepository employeesRepository) 
        {
            _employeesRepository = employeesRepository;
        } 

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeesRepository.GetAll());
        }
    }
}