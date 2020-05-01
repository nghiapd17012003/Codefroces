using System;

namespace _236A
{
    class Program
    {
        static void Main(string[] args)
        
            {
            var name = Console.ReadLine();
            char[] array = name.ToCharArray();
            int count = 0;
            for (int a = 0; a < name.Length; a++)
            {
                for (int b = a+1; b < name.Length; b++)
                {
                    if (array[a] == array[b])
                    {
                        count ++;
                    }
                }
            }

            if ((name.Length - count ) % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }

        }
    }
}
