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
        [TestMethod]
        public void DictCount()
        {
            Dictionary<int, Animal> MyData = AnimalData.ServerConn.DataDict();
            Console.WriteLine(MyData.Count.ToString());
            Assert.AreNotEqual(MyData.Count, 0);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Unit Test to check contrant
        /// </summary>
        /// returns constrant error
        [TestMethod]
        public void OutOfRange()
        {
            // arrange

            

        }
    
    }
}

