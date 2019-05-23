using System;

namespace Scratchname
{
    class Scratch
    {
        static void Main()
        {
            // ### sieve not good for big numbers : inefficient ~10 millionth prime. ###
            // ### crash at billionth prime (array dimension exceeded)               ###
            var watch = new System.Diagnostics.Stopwatch();
            //Console.Write("Input nmber:");      //
            //string input = Console.ReadLine();  // user input 
            //int num = Convert.ToInt32(input);   //
            watch.Start();
            //long num = 13;  // test value
            long num = 15485863; // millionth prime
            long range = num + 1; // stay within boundary
            bool[] sievearray = new bool[range]; // init empty array
            for (int i = 0; i < range; i++)
            {
                sievearray[i] = true;  // initialise array to true
            }
            sievearray[0] = false;  // zero not prime
            sievearray[1] = false;  // one not prime

            for (long j = 2; j < range; j++)
            {
                if (sievearray[j])  // if a number is still marked prime
                {
                    if ( j <= 10) // 1- 10 will mark everythin divisable by 2, 3, 5, & 7
                    {
                        for (long k = j * j; k < range; k += j) // start from square of num
                        {
                            sievearray[k] = false; // mark multiples as non prime
                        }
                    }
                    else  // miss all multiples of 2,3,5,7 as marked previously
                    {
                        if ( j % 2 != 0 || j % 3 != 0 || j % 5 != 0 || j % 7 != 0)
                        {
                            for (long k = j * j; k < range; k += j) // mark its multiples as non prime
                            {
                                if ( j*j < range) // make sure square isnt bigger than target
                                {
                                    sievearray[k] = false;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Is prime: {0}", sievearray[num]);
            watch.Stop();
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }

    }
}
