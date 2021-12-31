using System;
using System.Collections.Generic;

namespace exRegistro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int numEmployees = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 0; i < numEmployees; i++)
            {
                int num = i + 1;
                Console.WriteLine("Employees #" + num + ":");

                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine());

                Console.WriteLine();

                //Instanciação na memória os dados digitados
                list.Add(new Employees(Id, Name, Salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int chooseId = int.Parse(Console.ReadLine());

            //comando para encontrar o Id Digitado pelo usuário
            Employees IdUser = list.Find(x => x.Id == chooseId);

            if (IdUser != null)
            {
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine());
                IdUser.increaseSalary(perc);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");

            foreach(Employees employess in list)
            {
                Console.WriteLine(employess.Id +
                    ", " +
                    employess.Name +
                     ", " +
                     employess.Salary.ToString("F2")) ;
            }
        }
    }
}
