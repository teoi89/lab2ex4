using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number in order to find if it is a palindrome or not:");
            int n, reverse = 0, rem;
            n = int.Parse(Console.ReadLine());
            int m = n;
            while (m != 0)
            {
                rem = m % 10;
                reverse = reverse * 10 + rem;
                m = m / 10;
            }

            if (reverse == n)
            {
                Console.WriteLine("Your number " + n + " is a palindrome");
            }
            else
            {
                Console.WriteLine(n + " Is not a palindrome");
            }
        }
    }
}
