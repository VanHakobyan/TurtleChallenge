using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Turtle.Library;
using Turtle.Library.Models;
using Turtle.Library.Strategy;

namespace Turtle.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPoint()
        {
            Point point = new Point(10, 5);
            Assert.AreEqual(5,point.Y);
        }

        [TestMethod]
        public void TestObserver()
        {
            var observer=new Observer(new Grid(10,6));
            Assert.AreEqual(false,observer.IsDanger(new Point(5,5)));
        }

        [TestMethod]
        public void TestColor()
        {
            var colorGreen = typeof(White).BaseType?.ToString();
            var tString = typeof(Color).ToString();
            Assert.AreEqual(colorGreen,tString);
        }
    }
}
