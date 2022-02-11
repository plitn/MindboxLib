using NUnit.Framework;
using MindboxLib;
namespace MindboxLibTests
{
    public class CircleTests
    {
        [Test]
        public void AreaIsZeroTest()
        {
            //arrange
            int expected = 0;

            // act
            Circle cr = new Circle();
            double actual = cr.getArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}