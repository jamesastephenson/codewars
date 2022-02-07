// Abbreviate a Two Word Name
// Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.
// The output should be two capital letters with a dot separating them.
// https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/csharp

public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] names = name.Split(' ');
    return names[0][0].ToString().ToUpper() + "." + names[1][0].ToString().ToUpper();
  }
}