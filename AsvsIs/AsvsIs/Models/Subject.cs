using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsvsIs
{
    public abstract class Subject
    {   
        //Properties of the Subject Class
        public int  SubjectId { get; private set; }
        public string SubjectName { get; private set; }
        public double TotalMark { get; private set; }
        public double AssignmentMark { get; private set; }

    //Constructor to initialize the values
        private static int TempId = 1;
        public Subject(string subjectName, double assignmentMark, double marks)
        {
            this.SubjectName = subjectName;
            this.AssignmentMark = assignmentMark;
            this.TotalMark = assignmentMark + marks;
            SubjectId = TempId;
            TempId++;
        }
        

        //To String Method to display the details of the subject
        public override string ToString()
        {
            return $" SubjectId: {SubjectId}, SubjectName: {SubjectName}, TotalMarks: {TotalMark}. AssignmentMark : {AssignmentMark}";
        }

        

    }
}
