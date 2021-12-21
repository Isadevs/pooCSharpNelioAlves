using System;

namespace proj06_MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno estudante = new Aluno();

            Console.Write("Nome do aluno: ");
            estudante.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            estudante.NotaA = double.Parse(Console.ReadLine());
            estudante.NotaB = double.Parse(Console.ReadLine());
            estudante.NotaC = double.Parse(Console.ReadLine());

            estudante.Soma();
            double resultado = estudante.Soma();

            estudante.Resultado(resultado);
            
        }
    }
}
