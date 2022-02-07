// Count of Positives / Sum of Negatives
// given an int array, return an array where:
//  -the first element is the count of positive numbers
//  -the second element is the sum of all negative numbers
//  -if input array is empty or null, return an empty array
// https://www.codewars.com/kata/576bb71bbbcf0951d5000044/csharp

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
      if (input == null) {return new int[] {};}
      if (input.Length == 0) {return new int[] {};}
      int posCount = 0;
      int negSum = 0;
      int[] finalArr = new int[2];
      
      for (int i = 0; i < input.Length; i++) {
        if (input[i] > 0) { posCount++; }
        else if  (input[i] <= 0) { negSum += input[i];}
      }
      
      finalArr[0] = posCount; finalArr[1] = negSum;
      return finalArr;
    }
}