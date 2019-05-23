using System;
using System.Collections.Generic;

namespace Scratchname
{
    class Scratch
    {
        static Boolean primefunc(int target) // methods before main
        {
            if (target <= 1) return false; // 1 isnt prime
            if (target == 2) return true; // 2 is prime
            if (target % 2 == 0) return false; // evens arent prime
            var boundary = (int)Math.Floor(Math.Sqrt(target)); // only need to check upto sq root
            for (int i = 3; i <= boundary; i += 2) // increment thru odds
            {
                if (target % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            // 50 - 120 thousand ticks
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            long num = 600851475143;
            List<long> pflist = new List<long>(); // list to store prime factors
            long prod = 1; // store product of prime factors
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0 & primefunc(i) == true) // check if prime factor
                {
                    pflist.Add(i); // add to list
                    prod = 1; // reset product (must be at least 1)
                    foreach (var m in pflist) { prod *= m; } // multiply list contents   
                }
                if (prod == num) // if product = target, prime factor is highest
                {
                    Console.WriteLine("Answer: {0}", i);
                    break; // stop the for loop early
                }
            }
            watch.Stop();
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);



        }

    }
}
