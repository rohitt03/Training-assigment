using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Dto
{
    public class ResponseEntity
    {
        public string StatusCode { get; set; }
        public object Responce { get; set; }
    }
}
