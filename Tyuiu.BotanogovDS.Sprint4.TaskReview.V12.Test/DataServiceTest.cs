using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint4.TaskReview.V12.Lib;

namespace Tyuiu.BotanogovDS.Sprint4.TaskReview.V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 4;
            int[,] mx = new int[n, m];
            string str = "658932125478";
            int wait = 30;
            int res = ds.Calculate(n, m, str);
            Assert.AreEqual(res, wait);
        }
    }
}
