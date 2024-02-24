using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            TestmethodClass testmethodClass = new TestmethodClass();

            //Act
            var result = testmethodClass.Testmethod();

            //Assert
            Assert.AreEqual(result, 1);
        }
    }
}
