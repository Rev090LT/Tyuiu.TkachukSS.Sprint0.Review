using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint0.Review.TaskReview.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint0.Review.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X =" + x);
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y =" + y);
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Z =" + z);
            Console.WriteLine("Результат вычислений :" + DataService.Calc(x, y, z));
            Console.ReadKey();

        }
    }
}
