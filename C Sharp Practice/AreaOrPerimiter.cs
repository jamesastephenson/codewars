// Area or Perimeter
// given length and width:
// -if polygon is a square, return its area
// -if polygon is a rectangle, return its perimeter
// https://www.codewars.com/kata/5ab6538b379d20ad880000ab/csharp

public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
      if (l == w) {return l * w;}
      else {return (2*l) + (2*w);}
    }
}