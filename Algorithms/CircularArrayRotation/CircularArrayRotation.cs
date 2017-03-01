using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        int q = Convert.ToInt32(tokens_n[2]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse); 
        int[] b = new int[a.Length]; 

        int i,j;
        
        
        {
            int last;
            int Length=a.Length;
            for (i = 0; i < Length; i++)
            {
                b[(i+k)%Length]= a[i];
            }
        }

        int[] op = new int[q];
        for (i = 0; i < q; i++)
        {
            op[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < q; i++)
        {            
            Console.WriteLine(b[op[i]]);
        }
    }
}