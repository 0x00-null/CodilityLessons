using System;
using System.Linq;
using System.Collections.Generic;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (A.Length == 1)
            return A[0];
        if (A.Length == 2)
            return Math.Abs(A[0] - A[1]);
        // write your code in Java SE 8
        List<int> diffs = new List<int>();
        int left = 0;
        int sum = A.Sum();
        foreach (int item in A)
        {
            left += item;
            diffs.Add(Math.Abs(sum - left -left));
        }
        return diffs.Min();
    }
}