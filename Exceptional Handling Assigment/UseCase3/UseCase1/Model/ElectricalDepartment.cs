using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase3.Utils;
using UseCase3.CustomException;
namespace UseCase3.Model
{
    class ElectricalDepartment
    {
        public int Getdues(Student student)
        {
           
                try
                {
                    Dictionary<Student, int> stud = ElectricalDepartmentUtil.getStudentDetails();

                    LabsDepartment labdept = new LabsDepartment();
                    int nodues = labdept.Getdues(student);
                    if (!stud.ContainsKey(student))
                    {
                        throw new StudentNotFound("Student not found in Electrical department");
                    }
                    int temp;
                    stud.TryGetValue(student, out temp);
                    nodues += temp;
                    return nodues;
                }
                catch (Exception ex)
                {
                    Dictionary<Student, int> stud = ElectricalDepartmentUtil.getStudentDetails();
                    if (!stud.ContainsKey(student))
                    {
                        throw new StudentNotFound("Student not found in Electrical department",ex);
                    }
                    int temp;
                    stud.TryGetValue(student, out temp);
                    throw;
                }

            
      
         
        }
    }
}
