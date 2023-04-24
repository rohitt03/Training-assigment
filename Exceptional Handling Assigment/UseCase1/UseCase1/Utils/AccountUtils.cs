using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase1.Model;

namespace UseCase1.Utils
{
    class AccountUtils
    {
        public static Dictionary<Student,int> getStudentDetails()
        {
            Dictionary<Student, int> stud = new Dictionary<Student, int>();
            stud.Add(new Student("At101","suvijay","meshram"), 500);
            stud.Add(new Student("At102", "sanjay", "gauda"), 500);
            stud.Add(new Student("At103", "rushabh", "gunjal"), 500);
            stud.Add(new Student("At104", "yash", "patil"), 500);
            return stud;
        }
    }
}
