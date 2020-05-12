using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;

            Console.Write("enter text: ");

            inputValue = Console.ReadLine();

            Console.WriteLine(isPalindrome(inputValue));
        }

        public static bool isPalindrome(string text)
        {
            var textArr = text.ToCharArray();
            var arrLength = textArr.Length - 1;

            for (var i = 0; i < arrLength / 2; i++)
            {
                if (textArr[i] != textArr[arrLength - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
