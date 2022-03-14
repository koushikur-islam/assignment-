using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class FullTime:Employees, IEmployees
    {
        public double Bonus { get; set; }
        public FullTime(string id, string name, double salary, string joiningDate, double bonus):base(id, name, salary, joiningDate)
        {
            this.Bonus = bonus;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Showing Full Time Employee Info : ");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Joining Date : {JoiningDate}");
            Console.WriteLine($"Bonus : {Bonus}");
        }

        public void GrossIncome()
        {
            Console.WriteLine($"Gross Income : {(Salary * 12) + (2 * Bonus)}");
        }
    }
}
