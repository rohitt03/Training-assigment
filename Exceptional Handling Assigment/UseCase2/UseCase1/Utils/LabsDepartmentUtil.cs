using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase2.Model;
namespace UseCase2.Utils
{
    class LabsDepartmentUtil
    {
        public static Dictionary<Student, int> getStudentDetails()
        {
            Dictionary<Student, int> stud = new Dictionary<Student, int>();
            stud.Add(new Student("Gt504", "prathmesh", "shinde"), 500);
            stud.Add(new Student("At102", "sanjay", "gauda"), 500);
            stud.Add(new Student("At103", "rushabh", "gunjal"), 500);
            stud.Add(new Student("At104", "yash", "patil"), 500);
            return stud;
        }
    }
}
