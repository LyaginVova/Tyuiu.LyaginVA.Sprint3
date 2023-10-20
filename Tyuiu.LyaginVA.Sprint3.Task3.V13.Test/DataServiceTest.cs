using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint3.Task3.V13.Lib;

namespace Tyuiu.LyaginVA.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string str = "?sd!! 5gh. s!";
            

            double res = ds.ConvertStringToInt(str);

            int wait = 5;

            Assert.AreEqual(wait, res);


        }
    }
}
