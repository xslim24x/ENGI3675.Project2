using System;

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2_Engi3675;
using AnimalData;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Unit Test to Count entries in Database
        /// </summary>
        /// <returns>Prints the row count of Database[Integer]</returns>
        [TestMethod]
        public void DictCount()
        {
            Dictionary<int, Animal> MyData = AnimalData.ServerConn.DataDict();
            Console.WriteLine(MyData.Count.ToString());
            Assert.AreNotEqual(MyData.Count, 0);
        }


    }
}
