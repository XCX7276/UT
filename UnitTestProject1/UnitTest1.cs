using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod2()
        {
            int[] mass = { 4, 0, 3, 19, 492, -10, 1 };
            Assert.AreEqual(ConsoleApp2.Program.MinSum(mass), -10);
        } 
        [TestMethod]
        public void TestMethod3()
        {
            double[] mass = { 4,  0, 3, 19, 492, -10, 1 };
            Assert.AreEqual(ConsoleApp2.Program.MinSum(mass), -10);
        }
        [TestMethod]
        public void TestMethod4()
        {
            char[] mass = { 'f' };
            Assert.AreEqual(ConsoleApp2.Program.MinSum(mass), null);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string[] mass = { "ddd", "ddd", "ddd" };
            Assert.AreEqual(ConsoleApp2.Program.MinSum(mass), null);
        }
        [TestMethod]
        public void TestMethod6()
        {

            int[] nums = new int[4];
            Assert.AreEqual(ConsoleApp2.Program.MinSum(nums), 0);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int[] mass = { 1 };
            Assert.AreEqual(ConsoleApp2.Program.MinSum(mass), null);
        } 
    }
}
