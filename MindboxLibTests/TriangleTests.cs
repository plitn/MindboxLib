using NUnit.Framework;
using MindboxLib;
namespace MindboxLibTests
{
    public class TriangleTests
    {
        [Test]
        public void IsRightTriangle()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            bool expected = true;

            // act
            Triangle tr = new Triangle(a, b, c);
            double area = tr.getArea();
            bool actual = tr.isRight();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaWithSides10_20_30_Returns_0()
        {
            //arrange
            int a = 10;
            int b = 20;
            int c = 30;
            int expected = 0;

            // act
            Triangle tr = new Triangle(a, b ,c);
            double actual = tr.getArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}