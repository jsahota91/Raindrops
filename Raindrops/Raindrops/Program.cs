using System;

namespace Raindrops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FactorResults(28));
            Console.WriteLine(FactorResults(30));
            Console.WriteLine(FactorResults(34));
        }

        public static string FactorResults(int n)
        {
            string resultShort = (n % 105 == 0) ? "PlingPlangPlong" :
                                 (n % 35 == 0) ? "PlangPlong" :
                                 (n % 21 == 0) ? "PlingPlong" :
                                 (n % 15 == 0) ? "PlingPlang" :
                                 (n % 7 == 0) ? "Plong" :
                                 (n % 5 == 0) ? "Plang" :
                                 (n % 3 == 0) ? "Pling" :
                                 n.ToString();
            return resultShort;
        }

    }
}
