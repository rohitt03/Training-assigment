using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase1.Utils;
namespace UseCase1.Model
{
    class AccountDepartment
    {
        public int Getdues(string sid)
        {
            try
            {
                Student student = new Student();
                student.StudId = sid;
                Dictionary<Student, int> stud = AccountUtils.getStudentDetails();
                int nodues;
                stud.TryGetValue(student, out nodues);
                ElectricalDepartment eleDept = new ElectricalDepartment();
                nodues += eleDept.Getdues(student);
                return nodues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
