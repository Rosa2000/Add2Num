using Add2Num;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Add2NumTest
{
    [TestClass()]
    public class UnitTest1
    {
        MyBigNumber myBigNumber = new MyBigNumber();

        [TestMethod()]
        public void GetNumbersTest1()
        {
            int[] actualResult = myBigNumber.GetNumbers("1234", 4);
            int[] expectedResult ={ 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void GetNumbersTest2()
        {
            int[] actualResult = myBigNumber.GetNumbers("54", 2);
            int[] expectedResult = { 5, 4};
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void GetNumbersTest3()
        {
            int[] actualResult = myBigNumber.GetNumbers("1234567890", 10);
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        public void SumTest1()
        {
            string actualResult = myBigNumber.sum("112", "321");

            int expectedResult = 112 + 321;
            Assert.AreEqual(expectedResult.ToString(), actualResult);
        }

        [TestMethod()]
        public void SumTest2()
        {
            string actualResult = myBigNumber.sum("21", "2");

            int expectedResult = 21 + 2;
            Assert.AreEqual(expectedResult.ToString(), actualResult);
        }

        [TestMethod()]
        public void SumTest3()
        {
            string actualResult = myBigNumber.sum("12345", "246784");

            int expectedResult = 12345 + 246784;
            Assert.AreEqual(expectedResult.ToString(), actualResult);
        }
    }
}