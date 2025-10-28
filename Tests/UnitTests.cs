using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GithubActionsLab
{
    [TestClass]
    public class MathTests
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

        // 🔹 NEW TESTS for Power()
        [TestMethod]
        public void Power_Valid_Bhojwani()
        {
            Assert.AreEqual(8, Program.Power("2", "3"), 0.001, "Power(2,3) should return 8");
            Assert.AreEqual(16, Program.Power("4", "2"), 0.001, "Power(4,2) should return 16");
        }

        [TestMethod]
        public void Power_Negative_Bhojwani()
        {
            Assert.AreEqual(0.25, Program.Power("2", "-2"), 0.001, "Power(2,-2) should return 0.25");
        }

        [TestMethod]
        public void Power_Invalid_Bhojwani()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "b"));
        }
    }
}
