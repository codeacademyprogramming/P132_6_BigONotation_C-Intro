using System;

namespace _10082022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 3529;
            bool isPrime = true;
            int stepCount = 0;

            for(int i = 2; i*i <= n; i++)
            {
                stepCount++;
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true)
            {
                Console.WriteLine("Sadedir");
            }
            else
            {
                Console.WriteLine("Murekkebir");
            }

            Console.WriteLine(stepCount);

            int[] nums={ 34,10};
            int a = 0;
            int result = 10 / a;

        }
    }
}
