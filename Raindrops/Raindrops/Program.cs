using System;

namespace Raindrops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Factors(28));
            Console.WriteLine(Factors(34));
            Console.WriteLine(Factors(30));
        }

        public static string Factors(int n)
        {
            string result = "";
            if (n % 105 == 0) return result += "PlingPlangPlong";
            else if (n % 35 == 0) return result += "PlangPlong";
            else if (n % 21 == 0) return result += "PlingPlong";
            else if (n % 15 == 0) return result += "PlingPlang";
            else if (n % 7 == 0) return result += "Plong";
            else if (n % 5 == 0) return result += "Plang";
            else if (n % 3 == 0) return result += "Pling";
            else return result += n.ToString();
        }

    }
}
