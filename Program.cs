using System;

namespace _1348A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            double[] result = new double[t];
            for (int a = 0; a < t; a++)
            {
                int n = int.Parse(Console.ReadLine());
                double sum1 = 0;
                double sum2 = 0;
                for (int b = 1; b < n / 2; b++)
                {
                    sum1 += Math.Pow(2, b);
                }
                for (int c = n / 2; c < n; c++)
                {
                    sum2 += Math.Pow(2, c);
                }
                sum1 = sum1 + Math.Pow(2, n);
                result[a] = Math.Abs(sum1 - sum2);
            }
            for (int d = 0; d < t; d++)
            {
                Console.WriteLine(result[d]);
            }
            
        }
    }
}
