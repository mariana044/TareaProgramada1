using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProgramada1Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type an integer from 2 to 45: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2 || n > 45)
            {
                Console.WriteLine("Input is out of range");
                return;
            }

            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"Phi ~ {phi}");

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 2; i <= n; i++)
            {
                double ratio = (double)fib[i] / fib[i - 1];
                double diff = Math.Abs(phi - ratio);
                Console.WriteLine($"Fib({i}) / Fib({i - 1}) ~ {ratio} [+- {diff}]");
            }

            Console.WriteLine($"Fib({n}) = {fib[n]}");
            Console.WriteLine($"Fib({n - 1}) = {fib[n - 1]}");
        }
    }
}