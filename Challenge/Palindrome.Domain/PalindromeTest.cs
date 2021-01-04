using System;
using System.Text.RegularExpressions;

namespace Palindrome.Domain
{
    public class PalindromeTest
    {
        public bool CheckPalindrome(string str)
        {
            var name= Regex.Replace(str, @"[^0-9a-zA-Z\._]", "");
            string first = name.ToLower().Substring(0, name.Length / 2);
            char[] arr   = name.ToCharArray();

            Array.Reverse(arr);

            string temp   = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }


}
