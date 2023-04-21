using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
   public abstract class Person
    {
    
        public String Fname { get; set; }
        public String  Lname { get; set; }
        public DateTime Dob { get; set; }
        public  String MobileNo { get; set; }
        public String BloodGroup { get; set; }
        public String Gender { get; set; }
        public String IdentificationMark { get; set; }

        public Person() {}

        public Person(String Fname, String Lname, DateTime Dob)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Dob = Dob;
        }

        public override string ToString()
        {
            return "First Name:-"+Fname+" Last Name:-"+Lname+" Dob:-"+Dob;
        }


    }
}
