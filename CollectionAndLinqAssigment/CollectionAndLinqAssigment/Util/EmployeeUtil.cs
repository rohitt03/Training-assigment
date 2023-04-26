﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionAndLinqAssigment.Model;
namespace CollectionAndLinqAssigment.Util
{
    class EmployeeUtil
    {
        public static List<Employee>  GetallEmployee()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(1, "John Doe", "New York", 50000));
            employees.Add(new Employee(2, "Jane Smith", "Los Angeles", 60000));
            employees.Add(new Employee(3, "Bob Johnson", "Chicago", 45000));
            employees.Add(new Employee(4, "Mary Williams", "Houston", 55000));
            employees.Add(new Employee(5, "Mike Brown", "Philadelphia", 65000));
            employees.Add(new Employee(6, "Sarah Lee", "San Francisco", 70000));
            employees.Add(new Employee(7, "David Lee", "Boston", 40000));
            employees.Add(new Employee(8, "Amanda Wong", "Seattle", 75000));
            employees.Add(new Employee(9, "Jason Chen", "Miami", 50000));
            employees.Add(new Employee(10, "Karen Kim", "Washington D.C.", 80000));
            employees.Add(new Employee(11, "Tom Lee", "Dallas", 45000));
            employees.Add(new Employee(12, "Jessica Park", "San Diego", 55000));
            employees.Add(new Employee(13, "Eric Kim", "Atlanta", 60000));
            employees.Add(new Employee(14, "Linda Wong", "Denver", 70000));
            employees.Add(new Employee(15, "Chris Johnson", "Portland", 45000));
            employees.Add(new Employee(16, "Jenny Chen", "Phoenix", 50000));
            employees.Add(new Employee(17, "Brian Kim", "Minneapolis", 60000));
            employees.Add(new Employee(18, "Nancy Lee", "Detroit", 55000));
            employees.Add(new Employee(19, "Kevin Park", "Tampa", 65000));
            employees.Add(new Employee(20, "Amy Wang", "Charlotte", 75000));
            employees.Add(new Employee(21, "Mark Lee", "Las Vegas", 50000));
            employees.Add(new Employee(22, "Kelly Chen", "Salt Lake City", 60000));
            employees.Add(new Employee(23, "Steven Kim", "Nashville", 45000));
            employees.Add(new Employee(24, "Grace Lee", "New Orleans", 55000));
            employees.Add(new Employee(25, "Alex Kim", "Kansas City", 70000));
            employees.Add(new Employee(26, "Sandy Wong", "Orlando", 40000));
            employees.Add(new Employee(27, "Daniel Park", "Raleigh", 80000));
            employees.Add(new Employee(28, "Rachel Kim", "San Antonio", 50000));
            employees.Add(new Employee(29, "Paul Lee", "Cleveland", 60000));
            employees.Add(new Employee(30, "Stephanie Chen", "Indianapolis", 45000));
            employees.Add(new Employee(31, "Benjamin Kim", "Austin", 55000));
            employees.Add(new Employee(32, "Cindy Wong", "St. Louis", 70000));
            employees.Add(new Employee(33, "Andrew Park", "Kansas City", 50000));
            employees.Add(new Employee(34, "Melissa Lee", "Sacramento", 60000));
            employees.Add(new Employee(35, "Jacob Chen", "Oklahoma City", 45000));
            employees.Add(new Employee(36, "Megan Kim", "Milwaukee", 55000));
            employees.Add(new Employee(37, "Richard Lee", "Memphis", 70000));
            employees.Add(new Employee(38, "Tiffany Wong", "Louisville", 40000));
            employees.Add(new Employee(39, "Tony Park", "Albuquerque", 80000));
            employees.Add(new Employee(40, "Caroline Kim", "Rochester", 50000));
            employees.Add(new Employee(41, "Adam Lee", "Tucson", 60000));
            employees.Add(new Employee(42, "Hannah Chen", "Fresno", 45000));
            employees.Add(new Employee(43, "Sam Kim", "Omaha", 55000));
            employees.Add(new Employee(44, "Olivia Wong", "Virginia Beach", 70000));
            employees.Add(new Employee(45, "Jason Park", "Wichita", 40000));
            employees.Add(new Employee(46, "Emily Kim", "Boise", 80000));
            employees.Add(new Employee(47, "Justin Lee", "Providence", 50000));
            employees.Add(new Employee(48, "Vanessa Chen", "Anchorage", 60000));
            employees.Add(new Employee(49, "William Kim", "Birmingham", 45000));
            employees.Add(new Employee(50, "Lauren Wong", "Des Moines", 55000));
            int startingId = 51;
            employees.Add(new Employee(startingId, "Aarav Sharma", "Mumbai", 50000));
            employees.Add(new Employee(startingId + 1, "Aditi Singh", "Delhi", 60000));
            employees.Add(new Employee(startingId + 2, "Aditya Gupta", "Kolkata", 45000));
            employees.Add(new Employee(startingId + 3, "Alok Tiwari", "Bengaluru", 70000));
            employees.Add(new Employee(startingId + 4, "Amit Patel", "Chennai", 55000));
            employees.Add(new Employee(startingId + 5, "Ananya Chakraborty", "Hyderabad", 80000));
            employees.Add(new Employee(startingId + 6, "Aniket Singh", "Ahmedabad", 40000));
            employees.Add(new Employee(startingId + 7, "Anjali Nair", "Pune", 75000));
            employees.Add(new Employee(startingId + 8, "Ankit Verma", "Jaipur", 60000));
            employees.Add(new Employee(startingId + 9, "Anmol Jain", "Lucknow", 50000));
            employees.Add(new Employee(startingId + 10, "Anshul Gupta", "Kanpur", 65000));
            employees.Add(new Employee(startingId + 11, "Aryan Singh", "Nagpur", 45000));
            employees.Add(new Employee(startingId + 12, "Ashish Mishra", "Patna", 70000));
            employees.Add(new Employee(startingId + 13, "Bhavesh Shah", "Surat", 55000));
            employees.Add(new Employee(startingId + 14, "Chaitanya Singh", "Jaipur", 80000));
            employees.Add(new Employee(startingId + 15, "Deepak Yadav", "Chandigarh", 45000));
            employees.Add(new Employee(startingId + 16, "Devanshi Patel", "Ahmedabad", 60000));
            employees.Add(new Employee(startingId + 17, "Dhruv Singh", "Lucknow", 70000));
            employees.Add(new Employee(startingId + 18, "Divya Sharma", "Mumbai", 50000));
            employees.Add(new Employee(startingId + 19, "Gaurav Gupta", "Delhi", 75000));
            employees.Add(new Employee(startingId + 20, "Geeta Patel", "Bengaluru", 55000));
            employees.Add(new Employee(startingId + 21, "Himanshu Verma", "Kolkata", 80000));
            employees.Add(new Employee(startingId + 22, "Isha Singh", "Jaipur", 40000));
            employees.Add(new Employee(startingId + 23, "Jatin Sharma", "Chennai", 65000));
            employees.Add(new Employee(startingId + 24, "Kanika Verma", "Surat", 50000));
            employees.Add(new Employee(startingId + 25, "Kartik Nair", "Hyderabad", 70000));
            employees.Add(new Employee(startingId + 26, "Kavya Patel", "Ahmedabad", 55000));
            employees.Add(new Employee(startingId + 27, "Khushi Gupta", "Pune", 75000));
            employees.Add(new Employee(startingId + 28, "Krishna Singh", "Delhi", 60000));
            employees.Add(new Employee(startingId + 29, "Kunal Verma", "Kolkata", 45000));
            employees.Add(new Employee(startingId + 30, "Mahesh Sharma", "Mumbai", 70000));
            employees.Add(new Employee(startingId + 31, "Manish Singh", "Bengaluru", 55000));
            employees.Add(new Employee(startingId + 32, "Mayank Patel", "Jaipur", 80000));
            employees.Add(new Employee(startingId + 33, "Megha Nair", "Hyderabad", 45000));
            employees.Add(new Employee(startingId + 34, "Mihir Gupta", "Delhi", 65000));
            employees.Add(new Employee(startingId + 35, "Neha Singh", "Kolkata", 50000));
            employees.Add(new Employee(startingId + 36, "Nikita Verma", "Lucknow", 70000));
            employees.Add(new Employee(startingId + 37, "Nishant Patel", "Ahmedabad", 55000));
            employees.Add(new Employee(startingId + 38, "Pooja Nair", "Hyderabad", 80000));
            employees.Add(new Employee(startingId + 39, "Prachi Sharma", "Mumbai", 45000));
            employees.Add(new Employee(startingId + 40, "Pranav Singh", "Bengaluru", 70000));
            employees.Add(new Employee(startingId + 41, "Priya Gupta", "Jaipur", 55000));
            employees.Add(new Employee(startingId + 42, "Rahul Verma", "Pune", 75000));
            employees.Add(new Employee(startingId + 43, "Rajat Singh", "Kolkata", 60000));
            employees.Add(new Employee(startingId + 44, "Rakesh Sharma", "Delhi", 50000));
            employees.Add(new Employee(startingId + 45, "Riya Patel", "Ahmedabad", 65000));
            employees.Add(new Employee(startingId + 46, "Rohit Nair", "Hyderabad", 55000));
            employees.Add(new Employee(startingId + 47, "Sakshi Gupta", "Mumbai", 80000));
            employees.Add(new Employee(startingId + 48, "Samarth Singh", "Bengaluru", 45000));
            employees.Add(new Employee(startingId + 49, "Sanchit Verma", "Kolkata", 70000));
            employees.Add(new Employee(startingId + 50, "Sarika Patel", "Surat", 55000));
            return employees;
        }
    }
}