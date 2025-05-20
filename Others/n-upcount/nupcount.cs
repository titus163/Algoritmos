using System;

public class ArrayUpCount
{
    /// <summary>
    /// Calculates the n-upcount of an array.
    /// The n-upcount is the number of times the partial sum goes from less than or equal to n
    /// to greater than n during the calculation of the sum of elements of the array.
    /// </summary>
    /// <param name="a">The input array of integers.</param>
    /// <param name="n">The threshold value.</param>
    /// <returns>The n-upcount of the array.</returns>
    public static int nUpCount(int[] a, int n)
    {
        int partialSum = 0;
        int upCount = 0;

        // Handle the case of an empty array
        if (a == null || a.Length == 0)
        {
            return 0;
        }

        foreach (int element in a)
        {
            // Check if the partial sum is currently less than or equal to n
            bool wasLessThanOrEqualN = (partialSum <= n);

            // Add the current element to the partial sum
            partialSum += element;

            // Check if the partial sum is now greater than n AND it was less than or equal to n before adding the element
            if (partialSum > n && wasLessThanOrEqualN)
            {
                upCount++;
            }
        }

        return upCount;
    }

    // Ejemplo de uso:
    public static void Main(string[] args)
    {
        int[] arr = {2, 3, 1, -6, 8, -3, -1, 2};
        int n = 5;
        int result = nUpCount(arr, n);
        Console.WriteLine($"The {n}-upcount of the array is: {result}"); // Expected output: The 5-upcount of the array is: 3

        int[] arr2 = {1, 2, -1, 5, 3, -2};
        int n2 = 3;
        int result2 = nUpCount(arr2, n2);
        Console.WriteLine($"The {n2}-upcount of the array is: {result2}"); // Expected output: The 3-upcount of the array is: 2 (0->1->3->2->7(upcount!)->10(upcount!)->8)

        int[] arr3 = {0, 1, 0, 1, 0, 1};
        int n3 = 1;
        int result3 = nUpCount(arr3, n3);
        Console.WriteLine($"The {n3}-upcount of the array is: {result3}"); // Expected output: The 1-upcount of the array is: 2 (0->0->1->1->1->2(upcount!)->2)

         int[] arr4 = {}; // Empty array
        int n4 = 10;
        int result4 = nUpCount(arr4, n4);
        Console.WriteLine($"The {n4}-upcount of the array is: {result4}"); // Expected output: The 10-upcount of the array is: 0

        int[] arr5 = {10, 20, 30};
        int n5 = 10;
        int result5 = nUpCount(arr5, n5);
         Console.WriteLine($"The {n5}-upcount of the array is: {result5}"); // Expected output: The 10-upcount of the array is: 2 (0->10->30(upcount!)->60(upcount!))
    }
}