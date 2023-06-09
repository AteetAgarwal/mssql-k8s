using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI
{
    public class Employee
    {
        [Key]
        public int Emp_NO { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Add { get; set; }
        public string Emp_Phone { get; set; }
        public string Dept_No { get; set; }
        public string Dept_Name { get; set; }
        public string Salary { get; set; }
    }
}
