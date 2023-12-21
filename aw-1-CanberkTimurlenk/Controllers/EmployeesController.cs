using aw_1_CanberkTimurlenk.Models;
using Microsoft.AspNetCore.Mvc;

namespace aw_1_CanberkTimurlenk.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    [HttpPost]
    public Employee Post([FromBody] Employee value)
    {
        return value;
    }
}