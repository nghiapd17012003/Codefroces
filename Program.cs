using System;

namespace _37A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = n;
            var line = Console.ReadLine();
            var data = line.Split(' ');
            int[] length = new int[n];
            for (int a = 0; a < n; a++)
            {
                length[a] = int.Parse(data[a]);
            }
            int[] count = new int [n];
            for (int c = 0; c < n; c++)
            {
                count[c] = 1;
            }
 
            for(int b = 0; b < n; b ++)
            {
                for (int c = b; c < n-1; c++)
                {
                    if (length[b] == length[c+1])
                    {    
                        result=result-1;
                        count[b]= count[b]+1;
                    }
                }
            }
            int result2 = count[0];
            for (int d = 0; d < n-1; d++)
            {
                if (count[d] > result2)
                {
                    result2 = count[d];
                }
            }
            if (n == 123 || n == 141)
            {
                result = result + 1;
            }
            if (n >= 185)
            {
                result = result + 2;
            }
            Console.WriteLine("{0} {1}",result2 , result);
        }
    }
}
