using System;

namespace AD
{
    public class Opgave3
    {
        public static int OmEnOm(int n)
        {
            throw new System.NotImplementedException();
        }
        public static void Run()
        {
            int MAX = 20;

            for (int n = 0; n < MAX; n++)
            {
                System.Console.WriteLine("          OmEnOm({0,2}) = {1,3}", n, OmEnOm(n));
            }
        }
    }

    public class OmEnOmNegativeValueException : Exception
    {
    }
}
