using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorisovaDS.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;

            do
            {
                SumSeries = SumSeries + (Math.Pow((1 / ((Math.Cos(startValue)) + 2)), 2));
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(SumSeries, 3);
        }
    }
}
