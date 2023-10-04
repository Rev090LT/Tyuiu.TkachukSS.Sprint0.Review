using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint0.Review.TaskReview.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint0.Review.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(75, DataService.Calc(2, 5, 8));
        }
    }
}
