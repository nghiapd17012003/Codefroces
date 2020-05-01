using System;

namespace _1313A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] count = new int[a];  
            for (int b = 0; b < a; b++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                var x = int.Parse(data[0]); 
                var y = int.Parse(data[1]); 
                var z = int.Parse(data[2]);
                if (x > 3 && y > 3 && z > 3)
                {
                    count[b] = 7;
                }

                if (x == 0 && y == 0 && z == 0)
                {
                    count[b] = 0;
                }
                if (x == 1 && y == 1 && z == 1)
                {
                    count[b] = 3;
                }
                if ((x == 0 && y == 0 && z > 0) || (y== 0 && z == 0 && x > 0) || (z == 0 && x == 0 && y> 0))
                {
                    count[b] = 1;
                }
                if ((x == 0 && y == 1 && z >= 1) || (y == 0 && z == 1 && x>= 1) || (z == 0 && x == 1 && y >= 1))
                {
                    count[b] = 3;
                }
                if ((x == 0 && y > 1 && z > 1) || (y== 0 && z > 1 && x > 1) || (z == 0 && x> 1 && y> 1))
                {
                    count[b] = 3;
                }
                if ((x == 1 && y == 1 && z > 1) || (y == 1 && z== 1 && x> 1) || (z == 1 && x == 1 && y > 1))
                {
                    count[b] = 3;
                }
                if ((x == 1 && y> 1 && z > 1) || (y== 1 && z > 1 && x > 1) || (z == 1 && x > 1 && y > 1))
                {
                    count[b] = 4;
                }
                if (1 < x && x < 4 && 1 < y && y < 4 && 1 < z && z < 4)
                {
                    if (x >= y)
                    {
                        if (y >= z)
                        {
                            count[b] = 3 + z;
                        }
                        else
                        {
                            count[b] = 3 + y;
                        }
                    }
                    if (x < y)
                    {
                        if (x >= z)
                        {
                            count[b] = 3 + z;
                        }
                        else
                        {
                            count[b] = 3 + x;
                        }

                    }

                }
            }
            for (int j = 0; j < a; j++)
            {
                Console.WriteLine(count[j]);
            }

        }
    }
}
