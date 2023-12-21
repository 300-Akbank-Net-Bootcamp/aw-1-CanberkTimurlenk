using aw_1_CanberkTimurlenk.Models;
using Microsoft.AspNetCore.Mvc;

namespace aw_1_CanberkTimurlenk.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffsController : ControllerBase
{
    [HttpPost]
    public Staff Post([FromBody] Staff value)
    {
        return value;
    }
}