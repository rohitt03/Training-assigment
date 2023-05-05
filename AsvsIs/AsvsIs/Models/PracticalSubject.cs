using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsvsIs
{
    public class PracticalSubject : Subject
    {
        public double PracticalMarks { get;  private set; }
        public PracticalSubject(string subjectName, double assignmentMark, double practicalMarks) : base(subjectName, assignmentMark, assignmentMark)
        {
            this.PracticalMarks = practicalMarks;
        }

        public override string ToString()
        {
            return $" {base.ToString()} PracticalMarks: {PracticalMarks}";
        }

    }
}
