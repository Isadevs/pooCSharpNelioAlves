using System;

namespace proj01_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            //instanciar
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do Triângulo y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());



            Console.WriteLine("Hello World!");
        }
    }
}
