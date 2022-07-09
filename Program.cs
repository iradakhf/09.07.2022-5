using System;
namespace Arrays
{
    class Program
    {
        public static void Main (string[] args)
        {
            int n = 478;
            DisplayDigitsOfNumber(n);
        }
        public static void  DisplayDigitsOfNumber(int number)
        {
            int remainder = 0;
            while (number>0)
            {
                remainder = number % 10;
                number /= 10;
                Console.WriteLine(remainder);
            }
           
            

        }
    }
}
