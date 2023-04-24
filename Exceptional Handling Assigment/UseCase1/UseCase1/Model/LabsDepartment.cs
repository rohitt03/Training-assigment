using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase1.Utils;
using UseCase1.CustomException;
namespace UseCase1.Model
{
    class LabsDepartment
    {
        public int Getdues(Student student)
        {
            try
            {
                Dictionary<Student, int> stud = LabsDepartmentUtil.getStudentDetails();
                int nodues;
                if (!stud.ContainsKey(student))
                {
                    throw new StudentNotFound("student not found in labs department");
                }
                stud.TryGetValue(student, out nodues);
                return nodues;
               
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
