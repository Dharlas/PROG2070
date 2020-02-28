/*Kenneth Gering
 * Assignment 2
 * PROG2070
 *Revision Date:
 * Feb.28/20 project started
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    /// <summary>
    /// Class for solving information on a 3 sided object
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// method to analyze and return information on the triangle
        /// </summary>
        /// <param name="sideA">int for A side</param>
        /// <param name="sideB">int for B side</param>
        /// <param name="sideC">int for C side</param>
        /// <returns></returns>
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            int AB = sideA + sideB;
            int BC = sideB + sideC;
            int AC = sideA + sideC;

            string result = "";

            if (sideA == 0 || sideB == 0 || sideC == 0)
            {
                result = "This is not a triangle, every side must be larger than 0";
                Console.WriteLine(result);
                return result;
            }

            else if (AB < sideC || BC < sideA || AC < sideB)
            {
                result = "This is not a triangle, the sum of two sides must be greater than the third";
                Console.WriteLine(result);
                return result;
            }

            else if (sideA == sideB && sideB == sideC)
            {
                result = "It is an equilateral triangle";
                Console.WriteLine(result);
                return result;
            }

            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                result = "It is an isosceles triangle";
                Console.WriteLine(result);
                return result;
            }

            else
            {
                result = "It is a scalene triangle";
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
