using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");              //name of the program 
            Console.WriteLine("Find the prime numbers within a range of numbers:");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("GIVE ME FIRST NUMBER ");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("GIVE ME SECOND NUMBER ");
            int N2 = int.Parse(Console.ReadLine());
            int M;
            int K;
            int C;
            Console.Write("The prime numbers between {0} and {1} are : \n", N1, N2);


            for (M = N1; M <= N2; M++)
            {
                if (M == 1 || M == 0)
                    continue;
                K = 1;

                for (C = 2; C <= M / 2; ++C)
                {

                    if (M % C == 0)
                    {
                        K = 0;
                        break;

                    }
                }
                if (K == 1)

                    Console.WriteLine(M);
            }
        }
    }
}
