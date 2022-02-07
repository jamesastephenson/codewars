// Exes and Ohs
// return true if equal number of "x"s and "o"s, return false otherwise
// https://www.codewars.com/kata/55908aad6620c066bc00002a/csharp

using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int xCount = 0; int oCount = 0;
    char[] inputArr = input.ToLower().ToCharArray();
    for (int i = 0; i < inputArr.Length; i++) {
      if (inputArr[i].ToString() == "x") {xCount++;}
      else if (inputArr[i].ToString() == "o") {oCount++;}
      else {continue;}
    }
    
    if (xCount == oCount) { return true; }
    else { return false; }
  }
}