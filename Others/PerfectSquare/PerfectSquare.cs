using System;

public class PerfectSquare
{
    /// <summary>
    /// Returns the first perfect square that is strictly greater than the integer argument n.
    /// A perfect square is an integer that is equal to some integer squared.
    /// </summary>
    /// <param name="n">The input integer.</param>
    /// <returns>The first perfect square greater than n.</returns>
    public static int nextPerfectSquare(int n)
    {
        // If n is negative, the next perfect square greater than n is 0 (0 * 0).
        if (n < 0)
        {
            return 0;
        }

        // Find the integer part of the square root of n.
        // We use Math.Sqrt and cast to int. This effectively gives us floor(sqrt(n)) for non-negative n.
        int root = (int)Math.Sqrt(n);

        // The next integer whose square is greater than n will be root + 1.
        // We need to handle the case where n is already a perfect square.
        // If n is a perfect square, sqrt(n) will be an integer.
        // In this case, (int)Math.Sqrt(n) will be the exact integer square root.
        // To get the *next* perfect square, we still need (root + 1)^2.
        // If n is not a perfect square, (int)Math.Sqrt(n) is floor(sqrt(n)).
        // The next integer whose square is greater than n is also floor(sqrt(n)) + 1.

        // Calculate the next root
        int nextRoot = root + 1;

        // The next perfect square is the square of the next root.
        return nextRoot * nextRoot;
    }

    // Example Usage:
    public static void Main(string[] args)
    {
        Console.WriteLine($"Next perfect square after 6: {nextPerfectSquare(6)}");      // Expected: 9
        Console.WriteLine($"Next perfect square after 36: {nextPerfectSquare(36)}");    // Expected: 49
        Console.WriteLine($"Next perfect square after 0: {nextPerfectSquare(0)}");      // Expected: 1
        Console.WriteLine($"Next perfect square after -5: {nextPerfectSquare(-5)}");    // Expected: 0
        Console.WriteLine($"Next perfect square after 8: {nextPerfectSquare(8)}");      // Expected: 9
        Console.WriteLine($"Next perfect square after 9: {nextPerfectSquare(9)}");      // Expected: 16
    }
}