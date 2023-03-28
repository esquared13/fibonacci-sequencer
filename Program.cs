using System;

namespace fibonaccifinder
{

    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the desired length of the Fibonacci Sequence...");
            ulong n = Convert.ToUInt64(Console.ReadLine()); //sets length of sequence, represented by the variable n, to user input

            ulong f = 1; 
            ulong q = 0;
            ulong s = 0;

            for (ulong i = 0; i <= n;)
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