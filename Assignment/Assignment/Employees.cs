using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Employees
    {
        public string ID { get; set; }
        public string Name { get; set; }    
        public double Salary { get; set; }
        public string JoiningDate { get; set; }
        public Employees(string id, string name, double salary, string joiningDate)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
            this.JoiningDate = joiningDate;
        }
    }
}
