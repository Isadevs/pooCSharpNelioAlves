using System;
using System.Collections.Generic;
using System.Text;

namespace exRegistro
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percent)
        {
            Salary = ((percent * Salary) / 100) + Salary;
        }


    }
}
