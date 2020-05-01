using System;

namespace _38A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] d = new int[n - 1];
            var line1 = Console.ReadLine();
            var data1 = line1.Split(' ');
            for (int c = 0; c < n - 1; c++)
            {
                d[c] = int.Parse(data1[c]);
            }
            var line2 = Console.ReadLine();
            var data2 = line2.Split(' ');
            int a = int.Parse(data2[0]);
            int b = int.Parse(data2[1]);
            int sum = 0;
            for (int e = 0; e < b - a; e++)
            {
                sum =sum+d[a+e-1];
            }
            Console.WriteLine(sum);

        }
    }
}
