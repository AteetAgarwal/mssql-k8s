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

        public List<Common> CheckDBConnection()
        {
            Common emp = new Common();
            List<Common> lstCom = new List<Common>();
            emp.Table = null;
            try
            {
                if (_dbContext.Database.CanConnect())
                {
                    emp.StatusCode = 1;
                    emp.Message = "Database server is up";
                    emp.Status = "Sucess";
                }
                else
                {
                    emp.StatusCode = 0;
                    emp.Message = "Wait! Database server is not yet up";
                    emp.Status = "Fail";
                }
            }
            catch
            {
                emp.StatusCode = 0;
                emp.Message = "Wait! Database server is not yet up";
                emp.Status = "Fail";
            }
            lstCom.Add(emp);
            return lstCom;
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
                        emp.StatusCode = 0;
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

        public List<Common> AddEmployee(List<Employee> newEmp)
        {
            Common emp = new Common();
            List<Common> lstCom = new List<Common>();
            try
            {
                if (newEmp.Any(a => String.IsNullOrEmpty(a.Emp_Name)) || newEmp.Any(a => String.IsNullOrEmpty(a.Emp_Phone)) || newEmp.Any(a => String.IsNullOrEmpty(a.Dept_Name)))
                {
                    emp.Table = null;
                    emp.StatusCode = 0;
                    emp.Message = "Mandatory field are missing values.";
                    emp.Status = "Fail";
                }
                else
                {
                    _dbContext.Employees.AddRange(newEmp);
                    _dbContext.SaveChanges();
                    emp.Table = _dbContext.Employees.OrderByDescending(o => o.Emp_NO).ToList();
                    emp.StatusCode = 1;
                    emp.Message = "Record fetching sucessfully...";
                    emp.Status = "Sucess";
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
