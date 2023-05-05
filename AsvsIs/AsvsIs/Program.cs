using System;
using System.Collections.Generic;
using AsvsIs.Util;
using AsvsIs.Service;
using AsvsIs.Models;
namespace AsvsIs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome To Student Management System---------------");
            SubjectManagmentSystem subjectManagment = new SubjectManagmentSystem();         
            List<Subject> subjects = SubjectUtils.GetAllSubject();
            int ch = 1;
            while (ch != 99)
            {
                //Menu is provided to user to select the operation
                Console.Write("Enter\n 1:Counting theoty subjects \n2:Counting Practical subjects \n3:Deduct theory Marks by 10 \n99:Exit");
                String temp=Console.ReadLine();

                //Validating the input
                if (!int.TryParse(temp, out ch))
                    ch = 55;

                    
                //Switch case to perform the operation
                switch (ch)
                {
                    //Counting the theory subjects
                    case 1:
                        Console.WriteLine("----------Total theory subjects are--------");
                        Console.WriteLine(subjectManagment.CountOfTheorySubjects(subjects));
                        break;

                    //Counting the practical subjects
                    case 2:
                        Console.WriteLine("-------Total theory subjects are--------");
                        Console.WriteLine(subjectManagment.CountOfTheorySubjects(subjects));
                        break;

                    //Deducting the theory marks by 10    
                    case 3:
                        Console.WriteLine("-------subjects before marks deucted by 10--------");
                        foreach(var subject in subjects)
                        {
                            if(subject is TheorySubject|| subject is CommonSubject)
                            Console.WriteLine(subject);
                        }
                        subjectManagment.deductTheoryMarks(subjects);
                        Console.WriteLine("-------subjects after marks deucted by 10--------");
                        foreach (var subject in subjects)
                        {
                            if (subject is TheorySubject || subject is CommonSubject)
                                Console.WriteLine(subject);
                        }
                        break;

                    //Exit from the system    
                    case 99:
                        Console.WriteLine("Thanks for visiting ");
                        break;

                    //Default case    
                    default:
                        Console.WriteLine("Wrong Choice entered ");
                        break;
                }

            }      

        }
    }
}
