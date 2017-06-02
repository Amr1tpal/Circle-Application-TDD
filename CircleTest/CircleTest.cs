using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircleApplication;


namespace CircleTest
{
    [TestClass]
    public class CircleTest
    {
        public double circum { get; private set; }
        public double area { get; private set; }
        public double add { get; private set; }
        public double subtract { get; private set; }

        [TestMethod]
        public void TestcalculateCircum()
        {
            double radius=5.0;
            Circle circle = new Circle(radius);

          circum =   circle.circumference();


            Assert.AreEqual(31.42,circum);
        }

        public void TestcalculateCircum2()
        {
            double radius = 1;
            Circle circle = new Circle(radius);

            circum = circle.circumference();


            Assert.AreEqual(6.28, circum);
        }
        [TestMethod]
        public void TestcalculateArea()
        {
            double radius = 5.0;
            Circle circle = new Circle(radius);

            area = circle.area();
          Assert.AreEqual(78.54, area);
        }
        public void TestcalculateArea2()
        {
            double radius = 1.0;
            Circle circle = new Circle(radius);

            area = circle.area();
            Assert.AreEqual(3.14, area);
        }
        [TestMethod]
        public void TestAddRadius()
        {
            double radius = 5.0;
            Circle circle = new Circle(radius);

            circle.addRadiuss(2);
            Assert.AreEqual(7, circle.radius);
        }
        public void TestAddRadius2()
        {
            double radius = 10.0;
            Circle circle = new Circle(radius);

            circle.addRadiuss(1);
            Assert.AreEqual(11, circle.radius);
        }
        [TestMethod]
        public void TestSubRadius()
        {
            double radius = 5.0;
            Circle circle = new Circle(radius);

            circle.subRadiuss(2);
            Assert.AreEqual(3, circle.radius);
        }
        public void TestSubRadius2()
        {
            double radius = 11.50;
            Circle circle = new Circle(radius);
            circle.subRadiuss(10);
            Assert.AreEqual(1.5, circle.radius);
        }
    
    }
}
