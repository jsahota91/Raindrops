using System;

namespace Raindrops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static string Factors(int n)
        {
            if (n % 35 == 0) return "PlangPlong";
            else if (n % 21 == 0) return "PlingPlong";
            else if (n % 15 == 0) return "PlingPlang";
            else if (n % 7 == 0) return "Plong";
            else if (n % 5 == 0) return "Plang";
            else if (n % 3 == 0) return "Pling";
            else return n.ToString();
        }
    }
}
