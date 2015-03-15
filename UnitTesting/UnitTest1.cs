namespace UnitTesting
{
    using System;
    using System.Collections.Generic;
    using AnimalData;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Unit Test to Count entries in Database
        /// </summary>
        [TestMethod]
        public void DictCount()
        {
            Dictionary<int, Animal> myData = AnimalData.ServerConn.DataDict();
            Console.WriteLine(myData.Count.ToString());
            Assert.AreNotEqual(myData.Count, 0);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Unit Test checks Weight constraint
        /// </summary>
        [TestMethod]
        public void WeightOutOfRange()
        {
            // Animal.Weight = 555;
            // Constraint ranges between 0 - 500
        }
    }

    [TestClass]
    public class UnitTest3
    {
        /// <summary>
        /// Unit Test check NotNull constraint 
        /// </summary>
        [TestMethod]
        public void NotNullVariable()
        {
            // Animal.Breed = { };
            // Constrant: Animal.Breed Cannot be NULL
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
            // Animal.Age = 122;
            // Constraint ranges between 0-100 
        }
    }
}