﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_09
{
    public class Program
    {
        public static void Main()
        {
            unchecked
            {
                // int.MaxValue equals 2147483647
                int n = int.MaxValue;
                n = n + 1;
                System.Console.WriteLine(n);
            }
        }
    }
}