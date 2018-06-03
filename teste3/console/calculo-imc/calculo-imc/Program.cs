using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculo_imc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal altura, peso, imc;
            Console.WriteLine("CALCULO IMC\n");
            Console.WriteLine("Digite seu peso em Kg:\n");
            peso = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Digite sua altura em m:\n");
            altura = Convert.ToDecimal(Console.ReadLine());
            imc = peso / (altura * altura);
            Convert.ToInt16(imc);
            Console.WriteLine("Seu IMC é:" + imc);
            Console.ReadKey();


        }
    }
}
