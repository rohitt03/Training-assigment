using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsvsIs.Models
{
    class TheorySubject:Subject
    {
        public virtual double TheoryMarks { get;private set; }
        public TheorySubject(string subjectName, double assignmentMark, double theoryMarks) : base(subjectName, assignmentMark,assignmentMark + theoryMarks)
        {         
            this.TheoryMarks = theoryMarks;
        }

        public void Deducte10()
        {
            this.TheoryMarks -= 10;
        }

        public override string ToString()
        {
            return $" {base.ToString()} TheoryMarks: {TheoryMarks}";
        }

    }
}
