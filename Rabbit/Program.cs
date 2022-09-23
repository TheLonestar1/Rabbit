using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter mouth: ");
            int mouth;
            mouth = Convert.ToInt32(Console.ReadLine());
            List<int> sum  = new List<int>();
            sum.Add(2);
            sum.Add(4);
            for (int i = 2; i < mouth; i++) 
            {
               sum.Add(sum[i-1] + sum[i-2]);
            }
            Console.WriteLine(sum[mouth - 1]);

            Console.ReadKey();
        }
    }
}
