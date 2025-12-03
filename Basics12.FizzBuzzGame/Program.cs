namespace Basics12.FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Game (1-100):");
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                string result = FizzBuzz(i);
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("FizzBuzz Variation (with digit check):");
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                string result = FizzBuzzWithDigitCheck(i);
                Console.WriteLine(result);
            }
        }

        static string FizzBuzz(int zahl)
        {
            if (zahl % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (zahl % 3 == 0)
            {
                return "Fizz";
            }
            else if (zahl % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return zahl.ToString();
            }
        }



        static string FizzBuzzWithDigitCheck(int zahl)
        {
            bool isFizz = zahl % 3 == 0 || zahl.ToString().Contains('3');
            bool isBuzz = zahl % 5 == 0 || zahl.ToString().Contains('5');

            if (isFizz && isBuzz)
            {
                return "FizzBuzz";
            }
            else if (isFizz)
            {
                return "Fizz";
            }
            else if (isBuzz)
            {
                return "Buzz";
            }
            else
            {
                return zahl.ToString();
            }
        }
    }
}

