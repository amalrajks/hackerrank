using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(input[0]);
        int n2 = Convert.ToInt32(input[1]);
        int n3 = Convert.ToInt32(input[2]);
        int n4 = Convert.ToInt32(input[3]);
       int n5 = Convert.ToInt32(input[4]);

       long[] sum = {
           (n2+n3+n4+n5),
           (n1+n3+n4+n5),
           (n1+n2+n4+n5),
           (n1+n2+n3+n5),
           (n1+n2+n3+n4),
       };

       Console.Write(sum.Min()+" "+sum.Max());
    }
}