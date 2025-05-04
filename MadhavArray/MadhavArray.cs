using System;

public class MadhavArray
{
    /// <summary>
    /// Checks if an array is a Madhav array.
    /// A Madhav array has a length n that is a triangular number (n = i*(i+1)/2 for some integer i).
    /// The first element a[0] must be equal to the sum of the next i elements,
    /// the sum of the next i+1 elements, and so on.
    /// </summary>
    /// <param name="a">The input array of integers.</param>
    /// <returns>1 if the array is a Madhav array, 0 otherwise.</returns>
    public static int isMadhavArray(int[] a)
    {
        // First, check if the array length is a triangular number.
        // A triangular number is of the form k*(k+1)/2 for some integer k >= 1.
        // The smallest triangular number relevant here is 3 (for k=2, 2*(2+1)/2 = 3),
        // because the definition requires summing at least two elements after the first one.
        int length = a.Length;
        bool isTriangularLength = false;
        int k = 0; // This will store the 'k' if length is k*(k+1)/2

        // If the length is less than 1, it cannot be a Madhav array by definition's structure.
        // Although triangular numbers start from 1, the sum logic requires more elements.
        // The examples imply a minimum length where the sum check is possible.
        // The smallest length allowing the first sum (a[1]+a[2]) is 3.
        if (length < 1)
        {
             return 0;
        }


        for (int i = 1; ; i++) // Iterate to find if 'length' matches i*(i+1)/2
        {
            int triangularNumber = i * (i + 1) / 2;
            if (triangularNumber == length)
            {
                isTriangularLength = true;
                k = i; // Found the corresponding 'k' for the triangular length
                break; // Exit the loop once a match is found
            }
            if (triangularNumber > length)
            {
                break; // If the triangular number exceeds the length, it cannot be a match
            }
        }

        if (!isTriangularLength)
        {
            return 0; // If the length is not a triangular number, it's not a Madhav array
        }

        // If the length is triangular, check the sum property.
        // a[0] must equal the sum of the next 'round' elements.
        // The first group after a[0] starts with 2 elements (a[1] + a[2]).
        int startIndex = 1; // The index where the current group starts
        int elementsToSum = 2; // The number of elements to sum in the current group
        int firstValue = a[0];

        // Loop through the array, taking increasing groups of elements and summing them.
        // The loop continues as long as the starting index of the current group is within bounds.
        while (startIndex < length)
        {
            int endIndex = startIndex + elementsToSum - 1; // Calculate the inclusive end index for the current group

            // Check if the calculated endIndex is out of bounds.
            // If the array length is a valid triangular number and our logic is correct,
            // the last group should end exactly at index length - 1.
             if (endIndex >= length)
            {
                 // This indicates a problem in the logic or the input array structure
                 // if the initial triangular check passed but the end index is out of bounds.
                 // Based on the definition, this case means it's not a valid Madhav array structure.
                 return 0;
            }


            int sum = 0;
            // Sum the elements in the current group from startIndex to endIndex
            for (int i = startIndex; i <= endIndex; i++)
            {
                // This inner loop condition is safe because we checked endIndex >= length above.
                sum += a[i];
            }

            // Compare the calculated sum with the first element a[0].
            if (firstValue != sum)
            {
                return 0; // If any sum doesn't match a[0], it's not a Madhav array
            }

            // Prepare for the next round:
            startIndex = endIndex + 1; // The next group starts immediately after the current one
            elementsToSum++; // The next group will have one more element
        }

        // If the loop completed without finding any discrepancies, it's a Madhav array.
        return 1;
    }

    // Example Usage:
    public static void Main(string[] args)
    {
        Console.WriteLine($"{{2,1,1}}: {isMadhavArray(new int[]{{2, 1, 1}})}");                                      // Expected: 1
        Console.WriteLine($"{{2,1,1,4,-1,-1}}: {isMadhavArray(new int[]{{2, 1, 1, 4, -1, -1}})}");                     // Expected: 1
        Console.WriteLine($"{{6,2,4,2,2,2,1,5,0,0}}: {isMadhavArray(new int[]{{6, 2, 4, 2, 2, 2, 1, 5, 0, 0}})}");      // Expected: 1
        Console.WriteLine($"{{18,9,10,6,6,6}}: {isMadhavArray(new int[]{{18, 9, 10, 6, 6, 6}})}");                       // Expected: 0
        Console.WriteLine($"{{-6,-3,-3,8,-5,-4}}: {isMadhavArray(new int[]{{-6, -3, -3, 8, -5, -4}})}");                // Expected: 0
        Console.WriteLine($"{{0,0,0,0,0,0,0,0,0,0,1,1,1,-2,-1}}: {isMadhavArray(new int[]{{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, -2, -1}})}"); // Expected: 1
        Console.WriteLine($"{{3,1,2,3,0}}: {isMadhavArray(new int[]{{3, 1, 2, 3, 0}})}");                               // Expected: 0 (Length 5 is not triangular)
        Console.WriteLine($"{{1}}: {isMadhavArray(new int[]{1})}");                                                      // Expected: 0 (Length 1, not enough elements for sum check)
        Console.WriteLine($"{{}} : {isMadhavArray(new int[]{})}");                                                       // Expected: 0 (Empty array)
    }
}