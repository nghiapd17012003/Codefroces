using System;

namespace _1294A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] result = new string[t];
            for (int d = 0; d < t; d++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                int a = int.Parse(data[0]);
                int b = int.Parse(data[1]);
                int c = int.Parse(data[2]);
                int n = int.Parse(data[3]);
                int sum = 0;
                
                if (a >= b&&a >= c)
                {
                    sum = 2 * a - b - c;
                }
                if(b>= a&&b>= c)
                {
                    sum = 2 * b - a - c;
                }
                else
                {
                    sum = 2 * c - b - a;
                }
                if ((n - sum) % 3 == 0 && n-sum >=0)
                {
                    result[d] = "YES";
                }
                else
                {
                    result[d] = "NO";
                }

            }
            for (int e = 0; e < t; e++)
            {
                Console.WriteLine(result[e]);
            }

        }
    }
}
