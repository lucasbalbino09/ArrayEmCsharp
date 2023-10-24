using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Arranjo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int valorIncremento = n;
            double[] vect = new double[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("informe os valores " + valorIncremento-- + " Restantes!");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double res = soma / n;

            Console.WriteLine("A altura média é de: " + res.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
