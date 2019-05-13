using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = -1;
            double maxXpk = 0;
            double maxYpk = 0;
            double maxXpl = 0;
            double maxYpl = 0;
            int pk = 0;
            int pl = 0;

            Console.WriteLine("Enter n for polygon: ");
            int n = int.Parse(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter value for x" + i + ": ");
                x[i - 1] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter value for y" + i + ": ");
                y[i - 1] = double.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++) 
            {
                for (int j = 1; j <= n; j++)
                {
                    double newmax = Math.Sqrt((x[i - 1] - x[j - 1]) * (x[i - 1] - x[j - 1]) + (y[i - 1] - y[j - 1]) * (y[i - 1] - y[j - 1]));
                    if (newmax > max)
                    {
                        max = newmax;
                        pk = i;
                        pl = j;
                        maxXpk = x[i - 1];
                        maxYpk = y[i - 1];
                        maxXpl = x[j - 1];
                        maxYpl = y[j - 1];
                    }
                } 
            }
            Console.WriteLine("Max diagonal is: " + max);
            Console.WriteLine("First point is: " + pk + " Second point is: " + pl);
            Console.WriteLine("x for the first point is: " + maxXpk + " y for the first point is: " + maxYpk);
            Console.WriteLine("x for the second point is: " + maxXpl + " y for the second point is: " + maxYpl);
        }
    }
}
