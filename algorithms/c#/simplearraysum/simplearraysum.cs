// Creator Ben Stickney
// Date 3/19/2018

/*
Given an array of integers, find the sum of its elements.

Complete the simpleArraySum function which takes  arguments, an integer  and an integer array  and returns an integer denoting the sum of all array elements.

Raw Input Format

The first line contains an integer, , denoting the size of the array. 
The second line contains  space-separated integers representing the array's elements.

Sample Input 0

6
1 2 3 4 10 11
Sample Output 0

31
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int simpleArraySum(int n, int[] ar) {
		int sum = 0;
		
		for(int i = 0; i < n; i++)
			sum += ar[i];
		
		Console.WriteLine(sum);
		return sum;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(n, ar);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
