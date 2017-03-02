using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();    
        
        int Length = word.Length;
        int[] wh = new int[Length];

        for (int i = 0; i < Length; i++)
        {
            wh[i]=(int)word[i];
        }
        //int height= h[wh[0]-97];
        for(int i=0;i<Length;++i)
            {
            wh[i] = h[wh[i]-97];
        }
        Array.Sort(wh);
        Console.WriteLine(wh[Length-1]*Length);
    }
}
