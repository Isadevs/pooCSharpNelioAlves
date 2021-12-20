using System;

namespace proj_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {func.Nome}, R${func.SalarioLiquido().ToString()}");

            Console.Write($"Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);

            Console.WriteLine($"Dados atualizados: {func}");

        }
    }
}
