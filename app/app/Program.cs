using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllLIB;

namespace dllLIB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Введите первое число: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());
            Class1.PlusFunc(x, y);
            //Class1.MinusFunc(x, y);
            //Class1.UmnojitFunc(i, j);
            //Class1.RazdelitFunc(i, j);
            //Class1.StepenFunc(i, j);
        }
    }
}
