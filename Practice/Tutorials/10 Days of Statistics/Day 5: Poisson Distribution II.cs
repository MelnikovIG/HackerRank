using System;
using System.Linq;

namespace HakerrankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var meanA = 0.88;
            var meanB = 1.55;

            var poissonDistributionA = 160 + 40 * (meanA + meanA * meanA);
            var formattedResultA = poissonDistributionA.ToString("0.000");
            Console.WriteLine(formattedResultA);

            var poissonDistributionB = 128 + 40 * (meanB + meanB * meanB);
            var formattedResultB = poissonDistributionB.ToString("0.000");
            Console.WriteLine(formattedResultB);
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
