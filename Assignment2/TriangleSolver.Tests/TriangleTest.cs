using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TriangleSolver.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        /// <summary>
        /// Test to see if the triangle is an Equilateral
        /// </summary>
        [Test]
        public void IsItEquilateral_SidesAreAllEqual()
        {
            //Arrange
            int testA = 2;
            int testB = 2;
            int testC = 2;

            string testResult = "";

            //Act
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Assert
            StringAssert.Contains("It is an equilateral triangle", testResult);
        }

        /// <summary>
        /// Test to see if the triangle is a Scalene
        /// </summary>
        [Test]
        public void IsItScalene_NoSidesAreEqual()
        {
            //Arrange
            int testA = 4;
            int testB = 2;
            int testC = 3;

            string testResult = "";

            //Act
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Assert
            StringAssert.Contains("It is a scalene triangle", testResult);
        }

        /// <summary>
        /// Test to see if the triangle is an Isosceles
        /// </summary>
        [Test]
        public void IsItIsosceles_2SidesAreEqual()
        {
            //Act
            int testA = 2;
            int testB = 2;
            int testC = 3;

            string testResult = "";

            //Arrange
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Assert
            StringAssert.Contains("It is an isosceles triangle", testResult);
        }

        /// <summary>
        /// Test to see if the values make a traingle
        /// </summary>
        [Test]
        public void IsItATriangle()
        {
            //Act
            int testA = 4;
            int testB = 3;
            int testC = 8;

            string testResult = "";

            //Arrange
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Act
            StringAssert.Contains("This is not a triangle, the sum of two sides must be greater than the third", testResult);
        }

        /// <summary>
        /// Test to see if SideA is 0
        /// </summary>
        [Test]
        public void IsSideA0()
        {
            //Act
            int testA = 0;
            int testB = 2;
            int testC = 2;

            string testResult = "";

            //Arrange
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Act
            StringAssert.Contains("This is not a triangle, every side must be larger than 0", testResult);
        }

        /// <summary>
        /// Test to see if SideB is 0
        /// </summary>
        [Test]
        public void IsSideB0()
        {
            //Act
            int testA = 2;
            int testB = 0;
            int testC = 2;

            string testResult = "";

            //Arrange
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Act
            StringAssert.Contains("This is not a triangle, every side must be larger than 0", testResult);
        }

        /// <summary>
        /// Test to see if SideC is 0
        /// </summary>
        [Test]
        public void IsSideC0()
        {
            //Act
            int testA = 2;
            int testB = 2;
            int testC = 0;

            string testResult = "";

            //Arrange
            testResult = Assignment2.TriangleSolver.Analyze(testA, testB, testC);

            //Act
            StringAssert.Contains("This is not a triangle, every side must be larger than 0", testResult);
        }
    }
}
