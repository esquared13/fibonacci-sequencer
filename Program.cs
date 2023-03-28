using System;

namespace fibonaccifinder
{

    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the desired length of the Fibonacci Sequence...");
            ulong n = Convert.ToUInt64(Console.ReadLine()); // sets length of sequence, represented by the variable n, to user input

            ulong f = 1; 
            ulong q = 0;
            ulong s = 0;

            for (ulong i = 0; i <= n;) // the variable i keeps track of how many calculations have been made
            {
                // in this loop the values of variables are cycled through, since not all three values are needed at the same time
                q = f + s;
                i++;
                Console.WriteLine(q);
                
                if (i >= n){break;} // makes sure the sequence stops where the user specifies
                
                else
                {
                    s = q + f;
                    i++;
                    Console.WriteLine(s);
                }
                
                if (i >= n){break;} // makes sure the sequence stops where the user specifies
                
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