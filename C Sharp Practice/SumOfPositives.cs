// Sum of Positive
// given an array of integers, return the sum of all positive ints
// https://www.codewars.com/kata/5715eaedb436cf5606000381/csharp

using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
      if (arr[i] > 0) {sum += arr[i];}
    }
    return sum;
  }
}