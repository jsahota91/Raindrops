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
            if (n % 7 == 0)
            {
                return "Plong";
            }
            else if (n % 5 == 0)
            {
                return "Plang";
            } else if (n % 3 == 0)
            {
                return "Pling";
            }
            else return n.ToString();
        }
    }
}
