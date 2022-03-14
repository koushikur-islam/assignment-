using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class PartTime:Employees, IEmployees
    {
        public double Commission { get; set; }
        public PartTime(string id, string name, double salary, string joiningDate, double commission) : base(id, name, salary, joiningDate)
        {
            this.Commission = commission;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Showing Part Time Employee Info : ");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Joining Date : {JoiningDate}");
            Console.WriteLine($"Commission : {Commission}");
        }

        public void GrossIncome()
        {
            var grossIncome = (Salary + Commission);
            Console.WriteLine($"Gross Income : {grossIncome}");
        }
    }
}
