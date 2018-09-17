
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        //var nums = new[] {1.09, 1};
        var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var boysRatio = nums[0];
        var girlsRatio = nums[1];

        var boysNormalizedRatio = boysRatio / (boysRatio + girlsRatio);

        var distribution = Enumerable.Range(3,4).Sum(x => BinominalDistribution(x, 6, boysNormalizedRatio));

        var formatedResult = distribution.ToString("0.000");
        Console.WriteLine(formatedResult);
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
