using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Peterson()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Peterson()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Peterson()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid_Peterson() 
        {
            Assert.AreEqual(5, Program.Subtract("7","2"));
            Assert.AreEqual(9, Program.Subtract("18", "9"));
            Assert.AreEqual(45, Program.Subtract("50", "5"));
        }
        [Test]
        public void Multiply_Valid_Peterson()
        {
            Assert.AreEqual(16, Program.Multiply("8", "2"));
            Assert.AreEqual(125, Program.Multiply("25", "5"));
            Assert.AreEqual(117, Program.Multiply("39", "3"));
        }
        [Test]
        public void Divide_Valid_Peterson()
        {
            Assert.AreEqual(4, Program.Divide("8", "2"));
            Assert.AreEqual(5, Program.Divide("25", "5"));
            Assert.AreEqual(13, Program.Divide("39", "3"));
        }
        [Test]
        public void Pow_Valid_Peterson()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(81, Program.Power("3", "4"));
            Assert.AreEqual(1023, Program.Power("4", "5"));
        }
    }
}
