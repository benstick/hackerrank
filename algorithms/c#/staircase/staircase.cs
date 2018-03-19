// Creator Ben Stickney
// Date 3/19/2018

/*
Consider a staircase of size n = 4:

   #
  ##
 ###
####
Observe that its base and height are both equal to , and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size .

Input Format

A single integer, , denoting the size of the staircase.

Output Format

Print a staircase of size  using # symbols and spaces.

Note: The last line must have  spaces in it.

Sample Input

6 
Sample Output

     #
    ##
   ###
  ####
 #####
######

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void staircase(int n) {
		for(int i = 1; i <= n; i++)
			Console.WriteLine(new string(' ', n - i) + new string('#', i));
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
   
