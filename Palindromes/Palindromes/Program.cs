using System;

namespace Palindromes {

  internal static class Program {

    private static void Main() {
      Console.Write("Enter string: ");
      string name = Console.ReadLine();

      if (IsPalindrome(name)) {
        Console.WriteLine($"Yes, {name} is palindrome!");
      }
      else {
        Console.WriteLine($"No, {name} is not palindrome!");
      }
    }

    private static bool IsPalindrome(string text) {
      if (text.Equals(Reverse(text))) return true;
      return false;
    }

    private static string Reverse(string text) {
      char[] charArray = text.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
  }
}