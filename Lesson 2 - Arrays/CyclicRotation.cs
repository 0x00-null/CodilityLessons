using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        // In case the array inputed is empty or has only one element
        if (A.Length == 0 || A.Length == 1)
                {
                    return A;
                }
        // Declaring the array to be returned
        int[] result = new int[A.Length];

        // Resetting the number of rotations to the modulo of it self by the inputed array's length 
        // The goal is to reduce the rotation number when K<= A.length and to avoid that our indexer i doesn't go out of the array's length range.
        K = K % A.Length;
        for (int i = 0; i < K; i++)
        {
            result[K - 1 - i] = A[A.Length - 1 - i];
        }
        for (int j = 0; j < (A.Length - K); j++)
        {
            result[K + j] = A[j];
        }
        return result;
    }
}