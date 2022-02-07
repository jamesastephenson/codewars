// Reversed Sequence
// Build a function that returns an array of integers from n to 1 where n>0.
// https://www.codewars.com/kata/5a00e05cc374cb34d100000d/csharp

using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    // note: you need to define array length when you declare it
    int[] arr = new int[n];
    for (int i=0; i < n; i++) {arr[i] = n-i;}
    return arr;
  }
}