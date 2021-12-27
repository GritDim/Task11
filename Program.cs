using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите коэф-ты уравнения 0 = kx + b");
            Console.Write(" k = ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write(" b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Formula formula = new Formula(k, b);
            formula.Root();


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }



    }
    public struct Formula
    {
        public double k;
        public double b;

        public Formula(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public void Root()
        {
           Console.WriteLine(" корень уравнения 0 = {0}x + {1}, x = {2}", k, b, (-1) * b / k);

        }

    }
}
