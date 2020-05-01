using System;

namespace _231A
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfCase = int.Parse(Console.ReadLine());
            int count = 0;
            for (int a = 0; a < noOfCase; a++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                int z = int.Parse(data[2]);
                if (x + y + z >= 2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
