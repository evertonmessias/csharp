using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, media;
            Console.WriteLine("CALCULO MEDIA");
            Console.WriteLine("Digite nota 1 :");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite nota 2 :");
            n2 = Convert.ToDecimal(Console.ReadLine());
            media = (n1 + n2) / 2;
            Console.WriteLine("\nSua media é: " + media);
            Console.ReadKey();

        }
    }
}
