using System;

namespace salarioMedio
{
    class Program
    {
        static void Main(string[] args)

        {
            //criando objetos (Instanciando a classe funcionários);
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            //Funcionário 1
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (func1.salario + func2.salario) / 2.00;

            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2"));
        }
    }
}
