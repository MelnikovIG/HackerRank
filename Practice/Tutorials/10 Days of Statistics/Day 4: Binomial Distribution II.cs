using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        //var nums = new[] {12, 10};
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var ratio = nums[0];
        var batchSize = nums[1];

        var normalizedRatio = (double)ratio / 100;

        var distribution1 = Enumerable.Range(0,3).Sum(x => BinominalDistribution(x, batchSize, normalizedRatio));
        var formatedResult1 = distribution1.ToString("0.000");

        var distribution2 = Enumerable.Range(2, batchSize).Sum(x => BinominalDistribution(x, batchSize, normalizedRatio));
        var formatedResult2 = distribution2.ToString("0.000");

        Console.WriteLine(formatedResult1);
        Console.WriteLine(formatedResult2);
    }

    /// <summary>
    /// https://www.hackerrank.com/challenges/s10-binomial-distribution-1/tutorial
    /// </summary>
    /// <param name="x">number of successes</param>
    /// <param name="n">total number of trials</param>
    /// <param name="p">probability of success (normalized to 1)</param>
    /// <returns></returns>
    static double BinominalDistribution(int x, int n, double p)
    {
        var q = 1 - p;

        var combinations = Factorial(n) / (Factorial(x) * Factorial(n - x));
        var result = combinations * Math.Pow(p, x) * Math.Pow(q, n - x);
        return result;
    }

    static int Factorial(int num)
    {
        if (num <= 1)
            return 1;
        return num * Factorial(num - 1);
    }
}
