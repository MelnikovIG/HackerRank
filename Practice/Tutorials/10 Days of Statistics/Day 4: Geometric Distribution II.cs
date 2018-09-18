using System;
using System.Linq;

namespace HakerrankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var probabilities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var trails = int.Parse(Console.ReadLine());

            var probability = probabilities[0] / probabilities[1];

            var geometricDistribution = Enumerable.Range(1, trails).Sum(x => GeometricDistribution(x, probability));
            var formattedResult = geometricDistribution.ToString("0.000");

            Console.WriteLine(formattedResult);
        }

        /// <summary>
        /// GeometricDistribution
        /// </summary>
        /// <param name="n">number of trails</param>
        /// <param name="p">probability (from 0 to 1)</param>
        /// <returns></returns>
        static double GeometricDistribution(int n, double p)
        {
            var q = 1 - p;
            return Math.Pow(q, n - 1) * p;
        }
    }
}
