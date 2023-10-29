using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorisovaDS.Sprint3.Task3.V17.Lib;

namespace Tyuiu.BorisovaDS.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "*vn98n! b,";
            int res = ds.ConvertStringToInt(value);
            int wait = 98;
            Assert.AreEqual(res, wait);
        }
    }
}
