using CalculateLibrary.Calculators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateLibraryTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Example1()
        {
            var expr1 = "2+3";
            var ans1 = 5;
            Assert.AreEqual(ans1, StringCalculator.Calculate(expr1));
        }

        [TestMethod]
        public void Example2()
        {
            var expr2 = "(2+3)*6";
            var ans2 = 30;
            Assert.AreEqual(ans2, StringCalculator.Calculate(expr2));
        }

        [TestMethod]
        public void Example3()
        {
            var expr3 = "()+3)*6";
            Assert.ThrowsException<FormatException>(() => StringCalculator.Calculate(expr3));
        }

        [TestMethod]
        public void Example4()
        {
            var expr4 = "2+-6";
            var ans4 = -4;
            Assert.AreEqual(ans4, StringCalculator.Calculate(expr4));
        }

        [TestMethod]
        public void Example5()
        {
            var expr5 = "-(33*11)/-11";
            var ans5 = 33;
            Assert.AreEqual(ans5, StringCalculator.Calculate(expr5));
        }

        [TestMethod]
        public void Example6()
        {
            var expr6 = "-(33*11)/(-11)";
            var ans6 = 33;
            Assert.AreEqual(ans6, StringCalculator.Calculate(expr6));
        }

        [TestMethod]
        public void Example7()
        {
            var expr7 = "-2";
            var ans7 = -2;
            Assert.AreEqual(ans7, StringCalculator.Calculate(expr7));
        }
        [TestMethod]
        public void Example8()
        {
            var expr8 = "2//2";
            Assert.ThrowsException<FormatException>(() => StringCalculator.Calculate(expr8));
        }

        [TestMethod]
        public void Example9()
        {
            var expr9 = "2+3*5";
            var ans9 = 17;
            Assert.AreEqual(ans9, StringCalculator.Calculate(expr9));
        }

        [TestMethod]
        public void Example10()
        {
            var expr10 = "(-(+2-1))";
            var ans10 = -1;
            Assert.AreEqual(ans10, StringCalculator.Calculate(expr10));
        }
    }
}
