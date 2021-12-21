using System;
using System.Collections.Generic;
using System.Text;

namespace proj06_MediaAluno
{
    class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;


        public double Soma()
        {
            return NotaA + NotaB + NotaC;
        }

        public void Resultado(double resultado)
        {
            if(resultado >= 60)
            {
                Console.WriteLine("NOTA FINAL: " + resultado.ToString("F2"));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + resultado.ToString("F2"));
                Console.WriteLine("REPROVADO");
                resultado = 60 - resultado;
                Console.WriteLine("FALTARAM: " + resultado.ToString("F2") + " PONTOS");
            }
        }
    }
}
