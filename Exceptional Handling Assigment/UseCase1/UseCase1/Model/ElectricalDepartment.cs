using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase1.Utils;
namespace UseCase1.Model
{
    class ElectricalDepartment
    {
        public int Getdues(Student student)
        {
            try
            {
                Dictionary<Student, int> stud = ElectricalDepartmentUtil.getStudentDetails();
                int nodues;
                stud.TryGetValue(student, out nodues);
                LabsDepartment labdept = new LabsDepartment();
                nodues += labdept.Getdues(student);
                return nodues;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
