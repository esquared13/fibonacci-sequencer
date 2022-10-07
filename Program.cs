using System;

namespace fibonaccifinder
{

    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the desired length of the Fibonacci Sequence...");
            int n = Convert.ToInt32(Console.ReadLine()); //sets length of sequence, represented by the variable n, to user input

            int f = 1; 
            int q = 0;
            int s = 0;

            for (int i = 0; i <= n;)
            {
                q = f + s;
                i++;
                Console.WriteLine(q);
                
                if (i >= n){break;}
                
                else
                {
                    s = q + f;
                    i++;
                    Console.WriteLine(s);
                }
                
                if (i >= n){break;}
                
                else
                {
                    f = s + q;
                    i++;
                    Console.WriteLine(f);
                }
            }           
            Console.ReadKey();
        }
    }
}