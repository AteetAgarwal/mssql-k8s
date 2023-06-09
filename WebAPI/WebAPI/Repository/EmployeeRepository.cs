using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Interfaces;

namespace WebAPI
{
    public class EmployeeRepository : IEmployee
    {
        readonly DatabaseContext.DataBaseContext _dbContext = new();
        public EmployeeRepository(DatabaseContext.DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Common> GetEmployeeDetails()
        {
            Common emp = new Common();
            List<Employee> empList = new List<Employee>();
            List<Common> lstCom = new List<Common>();
            try
            {
                empList = _dbContext.Employees.ToList();
                if (empList != null)
                {
                    if (empList != null)
                    {
                        emp.Table = empList;
                        emp.StatusCode = 1;
                        emp.Message = "Record fetching sucessfully...";
                        emp.Status = "Sucess";
                    }
                }
                else
                {
                    {
                        emp.Table = null;
                        emp.StatusCode = 1;
                        emp.Message = "No Records found...?";
                        emp.Status = "Fail";
                    }
                }
            }
            catch
            {
                throw;
            }
            lstCom.Add(emp);
            return lstCom;
        }

    }
}
