using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class TriangleSolver
    {
        // This method is to analyze input 3 numbers as triangle sides,then decide if they can form a triangle and what type of triangle they can form
        public static string Analyze(int s1, int s2, int s3)
        {
            string message;
            if ((s1 + s2 > s3) && (s1 + s3 > s2) && (s2 + s3 > s1)) //for vallid triangle the sum of two sides should be greater than the third one
            {
                if ((s1 == s2) && s2 == s3)          //Equilateral triangle has 3 equal sides
                {
                    message = string.Format("A triangle with sides: {0}, {1}, and {2} is valid, and it is an Equilateral triangle.", s1, s2, s3);
                }
                else if (s1 == s2 || s1 == s3 || s2 == s3)     //If a triangle has two equal sides, It's called Isosceles
                {
                    message = string.Format("A triangle with sides: {0}, {1}, and {2} is valid, and it is a Isosceles triangle.", s1, s2, s3);
                }
                else
                {
                    //If no sides are equals the triangle is scalene
                    message = string.Format("A triangle with sides: {0}, {1}, and {2} is valid, and it is a Scalene triangle.", s1, s2, s3);
                }
            }
            else
            {
                message = string.Format("Invalid triangle sides!!");  //when the condition for valid triangle does not met, Invalid message created
            }
            return message;
        }
    }
}
