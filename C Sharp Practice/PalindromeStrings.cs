// Palindrome Strings
// return true if string is a palindrome, return false otherwise
// https://www.codewars.com/kata/57a5015d72292ddeb8000b31/csharp

using System;
using System.Linq;

public class Kata
{
  public static bool IsPalindrome(object line)
  {
    string lineStr = line.ToString();
    char[] arr = lineStr.ToCharArray();
    char[] reverseArr = lineStr.ToCharArray();
    Array.Reverse(reverseArr);

    // returns boolean based on if the sequences are the same
    return Enumerable.SequenceEqual(arr, reverseArr);
  }
}