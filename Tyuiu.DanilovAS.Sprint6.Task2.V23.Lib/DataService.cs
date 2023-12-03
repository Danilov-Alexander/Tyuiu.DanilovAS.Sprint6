using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DanilovAS.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // 4 - 2*x + (2+Math.Cos(x))/(2*x-2)
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2),3);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
