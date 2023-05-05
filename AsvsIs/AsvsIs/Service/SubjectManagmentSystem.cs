using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsvsIs.Models;

namespace AsvsIs.Service
{
    class SubjectManagmentSystem
    {
        // this method count the total number of subject which have theory.we use IS operator to check it 
        // we use List of Subject as parameter
        public int CountOfPracticalSubjects(List<Subject> subjects)
        {
            int count = 0;
            // we use foreach loop to iterate through the list of subjects
            foreach (var subject in subjects)
            {
                if (subject is PracticalSubject || subject is CommonSubject)
                    count++; // if it is PracticalSubject then it will increment the count

            }
            return count;
        }

        // this method count the  total number of subject which have pratctical.we use IS operator to check it 
        public int CountOfTheorySubjects(List<Subject> subjects)
        {
            int count = 0;
            foreach (var subject in subjects)
            {
                if (subject is TheorySubject || subject is CommonSubject)
                    count++;
            }
            return count;
        }


        //This method deduct 10 marks from theory subject
        //use as to cast it and called specific method
        public void deductTheoryMarks(List<Subject> subjects)
        {
            foreach (var subject in subjects)
            {
                // It Checks if the subject is TheorySubject or not
                TheorySubject obj = subject as TheorySubject;
                if (obj != null) // if it is TheorySubject then it will deduct 10 marks
                {
                    obj.Deducte10();
                    Console.WriteLine($" {subject.SubjectName} TheorySubject 10 deducted");
                }
                else // if it is not TheorySubject then it will print message
                {
                    Console.WriteLine($" {subject.SubjectName} Subject doesn't has TheorySubject");
                }
            }
        }
    }
}
