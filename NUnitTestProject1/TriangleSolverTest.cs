using NUnit.Framework;
using ConsoleApp1;

namespace Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {


        [Test]
        //Testing 1,2,and 7 if they form a triangle. The expected result 'invalid' message
        public void AnalyzeSides1_2_7()
        {
            //Arrange
            int s1 = 1;
            int s2 = 2;
            int s3 = 7;

            //Act

            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("Invalid triangle sides!!", result);
        }

        [Test]
        // Here two equal numbers are used 3,3 and the third number is 8.Expected invalid triangle sides "not Isosceles"
        public void AnalyzeSides3_3_8()
        {
            //Arrange
            int s1 = 3;
            int s2 = 3;
            int s3 = 8;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("Invalid triangle sides!!", result);
        }

        [Test]
        // Here two equal numbers are used 3,3 and 2. They form Isosceles triangle (side1=side2)
        public void AnalyzeSides3_3_3()
        {
            //Arrange
            int s1 = 3;
            int s2 = 3;
            int s3 = 2;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("A triangle with sides: 3, 3, and 2 is valid, and it is a Isosceles triangle.", result);
        }

        [Test]
        // Here two equal numbers are used 3,2 and 2. They form Isosceles triangle (side2=side3)
        public void AnalyzeSides3_2_2()
        {
            //Arrange
            int s1 = 3;
            int s2 = 2;
            int s3 = 2;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("A triangle with sides: 3, 2, and 2 is valid, and it is a Isosceles triangle.", result);
        }


        [Test]
        // Here three equal numbers are used 4,4 and 4. They form Equilateral triangle
        public void AnalyzeSides4_4_4()
        {
            //Arrange
            int s1 = 4;
            int s2 = 4;
            int s3 = 4;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("A triangle with sides: 4, 4, and 4 is valid, and it is an Equilateral triangle.", result);
        }

        [Test]
        // Here three equal numbers are used 6,6 and 6. They form Equilateral triangle
        public void AnalyzeSides6_6_6()
        {
            //Arrange
            int s1 = 6;
            int s2 = 6;
            int s3 = 6;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("A triangle with sides: 6, 6, and 6 is valid, and it is an Equilateral triangle.", result);
        }
        [Test]
        // Here three different numbers are used 4,2 and 5. They form a 'Scalene' triangle
        public void AnalyzeSides4_2_5()
        {
            //Arrange
            int s1 = 4;
            int s2 = 2;
            int s3 = 5;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("A triangle with sides: 4, 2, and 5 is valid, and it is a Scalene triangle.", result);
        }

        [Test]
        // Here three different numbers are used 3,4 and 5. They form a 'Scalene' triangle
        public void AnalyzeSides3_4_5()
        {
            //Arrange
            int s1 = 3;
            int s2 = 4;
            int s3 = 5;

            //Act
            string result = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual("A triangle with sides: 3, 4, and 5 is valid, and it is a Scalene triangle.", result);
        }

    }
}