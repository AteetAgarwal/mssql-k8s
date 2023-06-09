using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Common
    {
        public List<Employee>? Table { get; set; }
        [NotMapped]
        public string? Message { get; set; }
        [NotMapped]
        public int StatusCode { get; set; }
        [NotMapped]
        public string? Status { get; set; }
    }
}
