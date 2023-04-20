using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
   abstract class Human
    {
        public String Fname { get; set; }
        public String  Lname { get; set; }
        public DateTime Dob { get; set; }
        public  String MobileNo { get; set; }
        public String BloodGroup { get; set; }
        public String Gender { get; set; }
        public String IdentificationMark { get; set; }


    }
}
