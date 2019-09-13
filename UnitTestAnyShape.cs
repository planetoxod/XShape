using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnyShape;
using System;
namespace UnitTestProjectAnyShapes
{
    [TestClass]
    public class UnitTest_Circle
    {
        [TestMethod]
        public void TestMethod_AreaShape()
        {
            double r = 5;
            Circle circle = new Circle(r);
            double Sactual = circle.Area;                               // area actual
            double Sexpected = Math.PI * r * r;                           // area expected
            double delta = 0.001;
            Assert.AreEqual(Sexpected, Sactual, delta, "The area of the circle is not calculated correctly");
        }
    }
    [TestClass]
    public class UnitTest_Triangle
    {
        [TestMethod]
        public void TestMethod_AreaShape()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a,b,c);
            double Sactual = triangle.Area;                               // area actual
            double p = (a + b + c) / 2;                     
            double t = p * (p - a) * (p - b) * (p - c);
            double Sexpected;                                               // area expected
            Sexpected = Math.Sqrt(t); 
            double delta = 0.001;
            Assert.AreEqual(Sexpected, Sactual, delta, "The area of the triangle is not calculated correctly");
        }
        [TestMethod]
        public void TestMethod_IsRightTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            bool IsRight_actual = triangle.IsRightTriangle();                               // area actual
            bool IsRight_expected = true;                                               // area expected
            Assert.AreEqual<bool>(IsRight_expected, IsRight_actual, "Right angle check failed");
        }
    }
    [TestClass]
    public class UnitTest_XShape
    {
        [TestMethod]
        public void TestMethod_AreaShape()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
             XShape xShape = new XShape(triangle);
            double Sactual = xShape.Area;                     // area actual
            double p = (a + b + c) / 2;                     // polperimetra
            double t = p * (p - a) * (p - b) * (p - c);
            double Sexpected;
            if (t >= 0) Sexpected = Math.Sqrt(t); else Sexpected = 0;      // area expected
            double delta = 0.001;
            Assert.AreEqual(Sexpected, Sactual, delta, "The area of the triangle is not calculated correctly");
        }
    }
}
