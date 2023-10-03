using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GolubevDS.Sprint2.Task1.V9.Lib;

namespace Tyuiu.GolubevDS.Sprint2.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1054;
            int y = 375;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("Х = " + x);
            Console.WriteLine("Y = " + y);

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
