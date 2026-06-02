using System;
using System.Linq;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
                return;

            var program = new Program();

            foreach (var arg in args)
            {
                bool result = program.IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {result.ToString().ToLower()}");
            }
        }

        public bool IsPalindrome(string s)
        {
            // Local function to check if the string is a palindrome
            bool CheckPalindrome(string str)
            {
                string lower = str.ToLower();
                string reversed = new string(lower.Reverse().ToArray());
                return lower == reversed;
            }
 
            // Throw if null
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            
            // Return true if less than 2 characters
            if (s.Length < 2)
                return true;
            
            // Call the local function
            return CheckPalindrome(s);
        }
    }
}
