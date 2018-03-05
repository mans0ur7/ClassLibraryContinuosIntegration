using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryContinuosIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryContinuosIntegration.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            //arrange 
            Person person1 = new Person();
            //act
            string name = person1.GetName();
            //assert
            Assert.AreEqual(name, "Jonas");
        }
        /// <summary>
        /// Test som fejler, skulle se hvilken fejl vores build gav
        /// </summary>
        //[TestMethod()]
        //public void GetAddresseFejlTest()
        //{
        //    //arrange 
        //    Person person1 = new Person();
        //    //act
        //    string Address = person1.GetAddress();
        //    //assert
        //    Assert.AreEqual(Address, "Jernbanegade 3");
        //}

        [TestMethod()]
        public void GetAddresseTest()
        {
            //arrange 
            Person person1 = new Person();
            //act
            string Address = person1.GetAddress();
            //assert
            Assert.AreEqual(Address, "Elisagaardsvej 5");
        }
    }
}