// Creator Ben Stickney
// Date 3/18/2018

/*
Complete the function solveMeFirst to compute the sum of two integers.

Function prototype:

int solveMeFirst(int x, int y);

where,
x is the first integer input.
y is the second integer input

Return values
sum of the above two integers

Sample Input
x = 2
y = 3

Sample Output
5

*/

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int solveMeFirst(int a, int b) { 
       return a + b;
    }
    static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}      
