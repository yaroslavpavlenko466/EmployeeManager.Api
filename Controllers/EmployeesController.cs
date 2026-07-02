using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        List<string> employees = new List<string>();
        employees.Add("Ivan");
        employees.Add("Zahar");
        employees.Add("Petro");
        return Ok(employees);
    }
    
}