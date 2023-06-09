using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployee _IEmployee;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployee IEmployees)
        {
            _logger = logger;
            _IEmployee = IEmployees;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Common>>> GetEmployeeDetails()
        {
            return await Task.FromResult(_IEmployee.GetEmployeeDetails());
        }
    }
}
