using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
       public EmployeesController() 
       {

       } 

       [HttpGet]
       public IActionResult Get()
       {
           return Ok();
       }
    }
}