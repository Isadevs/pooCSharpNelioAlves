using System;

namespace proj07_ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar: ");
            double dolar = double.Parse(Console.ReadLine());

            double conversor = Cotacao.ConversorDeMoeda(cotacao, dolar);

            Console.WriteLine("Valor a ser pago em reais: " + conversor.ToString("F2"));
        }
    }
}
