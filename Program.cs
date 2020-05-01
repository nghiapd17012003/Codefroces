using System;
using System.IO;
namespace _1146A
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int count = 0 ;
            
            foreach (char d in x)
            {
                if (d== 'a')
                {
                    count++;
                }               
            }
            int n = x.Length - count;
            int m = n - count;
            if (m < 0)
            {
                Console.WriteLine(x.Length);
            }
            else
            {
                Console.WriteLine(x.Length - m - 1);
            }
            


        }

    }
}
