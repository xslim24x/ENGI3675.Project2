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
        /// Unit Test checks Weight contrant
        /// </summary>
            
        [TestMethod]
        public void WeightOutOfRange()
        {
            //  Animal.Weight = 555;
            //  Constrant ranges between 0 - 500
        }
    }

    [TestClass]
    public class UnitTest3
    {
        /// <summary>
        /// Unit Test check NotNull constrant 
        /// </summary>

        [TestMethod]
        public void NotNullVariable()
        {
            //  Animal.Breed = { };
            //  Constrant: Animal.Breed Cannot be NULL
        }
    }

    [TestClass]
    public class UnitTest4
    {
        /// <summary>
        /// Unit Test check Age constraint
        /// </summary>

        [TestMethod]
        public void AgeOutOfRange()
        {
            //  Animal.Age = 122;
            //  Constraint ranges between 0-100 
        }
    }
}

