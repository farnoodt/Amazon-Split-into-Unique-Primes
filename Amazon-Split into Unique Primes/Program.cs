using System;

namespace Amazon_Split_into_Unique_Primes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String s1 = "13499315";
            int l = s1.Length;
            
            Console.Write(countPrimeStrings(s1, l));
            Console.WriteLine("Hello World!");
        }



        static int countPrimeStrings(String number, int i)
        {
            // 1 based indexing
            if (i == 0)
                return 1;

            int cnt = 0;
            // Consider every suffix up to 6 digits
            for (int j = 1; j <= 6; j++)
            {
                // Number should not have a leading zero and it should be a prime number
                if (i - j >= 0 && number[i - j] != '0' && isPrime(number.Substring(i - j, j)))
                {
                    cnt += countPrimeStrings(number, i - j);
                   // cnt %= MOD;
                }
            }
            // Return the readonly result
            return cnt;
        }
        static bool isPrime(String number)
        {
            int num = Int32.Parse(number);
            for (int i = 2; i * i <= num; i++)
            {
                if ((num % i) == 0)
                    return false;
            }
            return num > 1 ? true : false;
        }
    }
}
