﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorisovaDS.Sprint3.Task7.V16.Lib;

namespace Tyuiu.BorisovaDS.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 0.96;
            valueWaitArray[1] = 0.76;
            valueWaitArray[2] = -0.14;
            valueWaitArray[3] = -0.91;
            valueWaitArray[4] = -0.84;
            valueWaitArray[5] = -0.00;
            valueWaitArray[6] = 0.84;
            valueWaitArray[7] = 0.91;
            valueWaitArray[8] = 0.14;
            valueWaitArray[9] = -0.76;
            valueWaitArray[10] = -0.96;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
