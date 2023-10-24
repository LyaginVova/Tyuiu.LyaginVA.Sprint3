using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LyaginVA.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;
            for (int x = startValue; x<= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res * (x / (Math.Cos(x) + x) + 0.5);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
