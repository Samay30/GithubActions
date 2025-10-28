using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GithubActionsLab
{
    // ---------------------- ADD ----------------------
    [TestClass]
    public class Addition
    {
        [TestMethod]
        public void Add_Valid_Bhojwani()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [TestMethod]
        public void Add_Invalid_Bhojwani()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
        }

        [TestMethod]
        public void Add_Null_Bhojwani()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
        }
    }

    // ---------------------- SUBTRACT ----------------------
    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void Subtract_Valid_Bhojwani()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }

        [TestMethod]
        public void Subtract_Invalid_Bhojwani()
        {
            Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "2"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "b"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("x", "y"));
        }

        [TestMethod]
        public void Subtract_Null_Bhojwani()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
        }
    }

    // ---------------------- MULTIPLY ----------------------
    [TestClass]
    public class Multiplication
    {
        [TestMethod]
        public void Multiply_Valid_Bhojwani()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(35, Program.Multiply("5", "7"));
        }

        [TestMethod]
        public void Multiply_Invalid_Bhojwani()
        {
            Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
            Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "b"));
            Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "y"));
        }

        [TestMethod]
        public void Multiply_Null_Bhojwani()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
        }
    }

    // ---------------------- DIVIDE ----------------------
    [TestClass]
    public class Division
    {
        [TestMethod]
        public void Divide_Valid_Bhojwani()
        {
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(3, Program.Divide("9", "3"));
            Assert.AreEqual(1, Program.Divide("5", "5"));
        }

        [TestMethod]
        public void Divide_Invalid_Bhojwani()
        {
            Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
            Assert.ThrowsException<FormatException>(() => Program.Divide("1", "b"));
            Assert.ThrowsException<FormatException>(() => Program.Divide("x", "y"));
        }

        [TestMethod]
        public void Divide_Null_Bhojwani()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
        }
    }

    // ---------------------- POWER ----------------------
    [TestClass]
    public class Power
    {
        [TestMethod]
        public void Power_Valid_Bhojwani()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(25, Program.Power("5", "2"));
        }

        [TestMethod]
        public void Power_Invalid_Bhojwani()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
            Assert.ThrowsException<FormatException>(() => Program.Power("1", "b"));
            Assert.ThrowsException<FormatException>(() => Program.Power("x", "y"));
        }

        [TestMethod]
        public void Power_Null_Bhojwani()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
