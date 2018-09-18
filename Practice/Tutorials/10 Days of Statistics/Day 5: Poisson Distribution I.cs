using System;
using System.Linq;

namespace HakerrankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var mean = double.Parse(Console.ReadLine());
            var value = int.Parse(Console.ReadLine());

            var poissonDistribution = PoissonDistribution(mean, value);
            var formattedResult = poissonDistribution.ToString("0.000");

            Console.WriteLine(formattedResult);
        }

        /// <summary>
        /// PoissonDistribution
        /// </summary>
        /// <param name="λ">average number of successes that occur in a specified region</param>
        /// <param name="k">actual number of successes that occur in a specified region</param>
        /// <returns></returns>
        static double PoissonDistribution(double λ, int k)
        {
            var result = (Math.Pow(λ, k) * Math.Pow(Math.E, -λ)) / Factorial(k);
            return result;
        }

        static int Factorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * Factorial(num - 1);
        }
    }
}
