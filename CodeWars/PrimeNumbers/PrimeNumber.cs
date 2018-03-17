﻿namespace PrimeNumbers
{
    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            else if (n <= 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;

            var i = 5;
            while (i * i <= n)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
                else
                    i += 6;

            return true;
        }
    }

}