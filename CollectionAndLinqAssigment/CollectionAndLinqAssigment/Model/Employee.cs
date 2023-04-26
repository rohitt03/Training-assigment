using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndLinqAssigment.Model
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name,string city,double salary)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return "ID:"+Id+" Name:"+Name+" City:"+City+" Salary:"+Salary;
        }

    }
}
