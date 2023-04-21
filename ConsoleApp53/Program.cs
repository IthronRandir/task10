using System;

namespace ConsoleApp
{
    class Program
    {
        static void SumOfN(int a1, int d, int n)
        {
            int Sn = (2 * a1 + d * (n - 1)) / 2 * n;
            
            Console.WriteLine(Sn);
        }
        static void Main(string[] args)
        {
            int a1 = 2;
            int d = 3;
            int n = 5;
            SumOfN(a1, d, n);
        }
    }
}
