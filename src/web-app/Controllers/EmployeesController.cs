using Microsoft.AspNetCore.Mvc;
using web_app.Data;

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
    }
}