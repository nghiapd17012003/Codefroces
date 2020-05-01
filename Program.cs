using System;

namespace _1296B
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfCase = int.Parse(Console.ReadLine());
            double[] Result = new double[NoOfCase];
            double[] k = new double[NoOfCase];
            for (int a = 0; a < NoOfCase; a++)
            {             
                string InPut = Console.ReadLine();
                int InPutNo = int.Parse(InPut);              
                var sum1 = 0;
                int Sum = 0;
                foreach (var element in InPut)
                {
                    sum1 += Convert.ToInt32(element.ToString());
                }
                for (int b = 0; b < InPut.Length; b++)
                {
                    Sum = Sum +InPutNo;
                    InPutNo = (InPutNo - InPutNo % 10) / 10;
                }   
                Result[a] = Result[a] = (Sum + sum1/ 10);
                k[a] = Result[a];
                Math.Round(k[a], 0, MidpointRounding.AwayFromZero);

                
            }
            for (int c = 0; c < NoOfCase; c++)
            {
               
                Console.WriteLine(k[c]);
            }

        }
    }
}
