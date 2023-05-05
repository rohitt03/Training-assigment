using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsvsIs.Models
{
    public class CommonSubject : Subject
    {
        public double PracticalMarks { get; private set; }
        public double TheoryMarks { get; private set; }
        public CommonSubject(string subjectName, double assignmentMark, double PracticalMarks, double TheoryMarks) : base(subjectName, assignmentMark, PracticalMarks + assignmentMark+ TheoryMarks)
        {
            this.PracticalMarks = PracticalMarks;
            this.TheoryMarks = TheoryMarks;
        }

        public override string ToString()
        {
            return $" {base.ToString()} Practical Marks : {PracticalMarks}, Theory Marks : {TheoryMarks}";
        }
    }
}
