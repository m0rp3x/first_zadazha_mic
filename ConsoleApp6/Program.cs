using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        var ls = new int[] {1,4,8,8,1,3,3,7,2};

        List<int> aboba = new List<int>();

        foreach (var i in ls)
        {
            Console.Write($" {i} ");
        }

        Console.WriteLine();

        foreach (var i in ls)
        {
            var x = (Array.IndexOf(ls, i) % 2 != 0);
            if (x)
            {
                

                aboba.AddRange(new[] {i});
            }
        }

        Console.WriteLine();
        
        aboba.Sort((a, b) => b - a);

        


        foreach (var i in aboba)
        {
            Console.Write($" {i} ");
        }

        Console.WriteLine();

        for (int i = 0; i < ls.Length; i++)
        {
            if (i % 2 != 0 )
            {
                ls[i] = aboba[i / 2 ];
                
              
                
            }
        }

        Console.WriteLine(string.Join(' ', ls));

     

        
    }
}