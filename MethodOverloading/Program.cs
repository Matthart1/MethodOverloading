using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lets add two integers:");
            var answer = Add(3, 4);
            //Console.WriteLine("Lets add two decimals:");
            var secondAnswer = Add(10.20, 20.2);
            //Console.WriteLine("Do you have 30 dollars?:");
            var thirdAnswer = Add(10, 20, true);

            Console.WriteLine($"Lets add two integers: {answer}, now lets add two dec. {secondAnswer}, do you have $30? {thirdAnswer}" );
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double a, double b)
        {
            return a + b;

        }

        public static string Add(int x, int y, bool something)
        {
            var sum = x + y;
            if (something == true && sum > 1)
            {

                return $"{sum} dollars";



            }

            else if (something == true && sum == 1)
            {
                return $"{sum} dollar";
            }

            else if (something == true && sum < 1)
            {
                return $"{sum} dollar(s)";
            }

            else
            {
                return sum.ToString();
            }

        }
    }
}
