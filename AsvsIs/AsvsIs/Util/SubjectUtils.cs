using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsvsIs.Models;

namespace AsvsIs.Util
{
    class SubjectUtils
    {
        public static List<Subject> GetAllSubject()
        {
            // Create a list of subject
            List<Subject> li = new List<Subject>();
            li.Add(new TheorySubject("English",50,50));
            li.Add(new TheorySubject("Marathi", 50, 50));
            li.Add(new TheorySubject("SST", 50, 50));
            li.Add(new PracticalSubject("PT",50,50));
            li.Add(new PracticalSubject("Music", 50, 50));
            li.Add(new CommonSubject("Physics", 50, 50,50));
            li.Add(new CommonSubject("Chemistry", 50, 50, 50));

            // Return the list
            return li;
        }

        // Display all subject
        public static void Display()
        {
            foreach(Subject subject in GetAllSubject())
            {
                Console.WriteLine(subject.ToString());
            }
        }
    }
}
