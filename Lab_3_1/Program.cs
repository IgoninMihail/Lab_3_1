using System;

namespace Lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число N:");
                int N = int.Parse(Console.ReadLine());
                for (int i = 10; i <= N; i++)
                {
                    int S = 0;
                    int m = 0;
                    int k = i;
                    while (k != 0)
                    {
                        m = k % 10;
                        S += k % 10;
                        k /= 10;
                    }
                    Console.WriteLine(i + " " + m + " " + S);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
