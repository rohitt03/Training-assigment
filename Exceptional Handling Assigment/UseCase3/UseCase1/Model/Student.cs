using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase3.Model
{
    class Student
    {
        public string StudId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public Student() { }
        public Student(string studi,string fname,string lname)
        {
            this.StudId = studi;
            this.Fname = fname;
            this.Lname = lname;
        }
        public override bool Equals(object obj)
        {
            return this.StudId==((Student)obj).StudId;
        }
        public override int GetHashCode()
        {
            return this.StudId.GetHashCode();
        }

    }
}
