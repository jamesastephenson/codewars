// Binary Addition
// https://www.codewars.com/kata/551f37452ff852b7bd000139/csharp

using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
    int sum = a + b;
    // second argument specifies we're converting to base 2 (binary)
    string binaryStr = Convert.ToString(sum, 2);
    return binaryStr;
  }
}