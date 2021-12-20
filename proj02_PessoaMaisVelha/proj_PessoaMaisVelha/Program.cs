using System;

namespace proj_PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas Pessoa1, Pessoa2;

            Pessoa1 = new Pessoas();
            Pessoa2 = new Pessoas();

            Console.WriteLine("Entre com os dados da primeira pessoa:");
            Console.Write("Nome: ");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da segunda pessoa:");
            Console.Write("Nome: ");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa2.Idade = int.Parse(Console.ReadLine());

            if(Pessoa1.Idade > Pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + Pessoa2.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + Pessoa2.Nome);
            }
        }
    }
}
