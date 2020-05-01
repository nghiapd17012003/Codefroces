using System;

namespace _1312A
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfCase = int.Parse(Console.ReadLine());
            int[] count = new int[NoOfCase];
            for (int a = 0; a < NoOfCase; a++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                int n = int.Parse(data[0]);// so canh cua da giac luc dau   
                int m = int.Parse(data[1]);// so canh cua da giac ma minh muon build
                if (n % m == 0)
                {
                    count[a] = 0;
                }
                else
                {
                    count[a] = 1;
                }
            }
            for (int b = 0; b < NoOfCase; b++)
            {
                if (count[b] == 0)
                {
                    Console.WriteLine("YES");
                }
                if (count[b] == 1)
                {
                    Console.WriteLine("NO");
                }

            }
        }
    }
}
