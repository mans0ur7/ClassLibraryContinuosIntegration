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
    }
}