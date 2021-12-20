using System;
using System.Collections.Generic;
using System.Text;

namespace proj_Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double SalarioLi;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = ((SalarioBruto * porcentagem) / 100 + SalarioBruto);
        }

        public override string ToString()
        {
            return $"Dados atualizados: {Nome}, R${SalarioLiquido().ToString("F2")} ";
        }
    }
}
