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
        public IActionResult Post([FromBody]Employee employee)
        {
            _employeesRepository.Add(employee);
            return Created($"/employees/{employee.Id}", employee);
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]Employee employee)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeesRepository.Delete(id);
            return NoContent();
        }
    }
}