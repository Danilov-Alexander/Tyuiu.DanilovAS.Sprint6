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
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2.0 * x - 2.0) == 0)
                {
                    vallueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((4.0 - 2.0 * x + (2.0 + Math.Cos(x)) / (2.0 * x - 2.0)), 2);
                    vallueArray[count] = y;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}
