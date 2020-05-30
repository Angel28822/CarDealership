using Car_Dealership;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Car_Dealership.TestsCars
{
    
    [TestFixture]
    public class TestClass
    {

        private Cars cars;

        [Test]
        public void TestChackBrandNull()
        {
            this.cars = new Cars(1, "", "BMW");
            Assert.AreEqual("",cars.Brand,"The Brand cannot be null!");

        }

        [TearDown]
        public void TestCleanUp() { }
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
    }
}
