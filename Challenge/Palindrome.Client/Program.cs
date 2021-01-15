using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
       
        static void Main(string[] args)
        {
            PalindromeTest palindrome = new PalindromeTest();
            Console.WriteLine("Enter a word or sentence, I will tell you whether it is palindrome or not: ");
            string wordOrSentence = Console.ReadLine();
            
            bool IsPalindrome = palindrome.CheckPalindrome(wordOrSentence);
            bool quit = false;

            while(!quit)
            {
                if(IsPalindrome)
                {
                    Console.WriteLine("You word is palindrome, nice job!");
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                    wordOrSentence = Console.ReadLine();
                    IsPalindrome = palindrome.CheckPalindrome(wordOrSentence);
                }
            }
            
            
        }
    }
}
