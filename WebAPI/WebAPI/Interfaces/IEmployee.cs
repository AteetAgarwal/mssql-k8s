using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface IEmployee
    {
        public List<Common> GetEmployeeDetails();
    }
}
