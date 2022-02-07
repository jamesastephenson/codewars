// Calculate BMI
// https://www.codewars.com/kata/57a429e253ba3381850000fb/csharp

public class Kata
{
  public static string Bmi(double weight, double height)
  {
    double bmi = weight / (height * height);
    if (bmi > 18.5) {
      if (bmi <= 25) {return "Normal";}
      else if (bmi <= 30) {return "Overweight";}
      else {return "Obese";}
    }
    else {return "Underweight";}
  }
}