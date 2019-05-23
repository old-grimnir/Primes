using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Scratch2name
{
    class Scratch2
    {
        static void Main()
        {
            // using a bit array (again, not good for huge numbers)
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start(); 
            long num = 15485863;
            //int num = 13;
            long range = num + 1;
            BitArray pl = new BitArray((int)range);

            pl.SetAll(true);

            pl[0] = false; // 0 not prime
            pl[1] = false; // 1 not prime

            for (long j = 2; j < range; j++) // start at 2
            {
                if (pl[(int)j]) // look for 'true'
                {

                    if ( j <= 10)
                    {
                        for (long k = j * j; k < range; k += j)
                        {
                            pl[(int)k] = false; // mark out all multiples
                        }
                    }
                    else
                    {
                        if ( j % 2 != 0 || j % 3 != 0 || j % 5 != 0 || j % 7 != 0)
                        {
                            for (long k = j + j; k < range; k += j)
                            {
                                pl[(int)k] = false; // mark out all multiples   
                            }
                        }
                    }                    
                }
            }
            Console.WriteLine("Is prime: {0}", pl[(int)num]);
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
