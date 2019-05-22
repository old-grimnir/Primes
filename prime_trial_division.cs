using System;
using System.Collections;

namespace Scratch3name
{
    class Scratch3
    {
        static Boolean primefunc(long target) // find primes via trial division
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
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //Console.WriteLine("Is prime: {0}", primefunc(15485863)); // millionth prime
            //Console.WriteLine("Is prime: {0}", primefunc(22801763489)); // billionth prime
            Console.WriteLine("Is prime: {0}", primefunc(252097800623)); // ten billionth prime    
            watch.Stop();
            Console.WriteLine("Took: {0} ticks", watch.ElapsedTicks);
            Console.WriteLine("Took: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
