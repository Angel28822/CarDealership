using Car_Dealership;
using Car_Dealership.Data;
using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.TestsCars
{
    [TestFixture]
    public class TestClassCarsData
    {
        [Test]
        public void TestMethod()
        {
          /*  var data = new List<Cars>
            {
                new Cars(1,"rrrr","kkkk") {  },
                new Cars ( 2,"fdfd","nnnn"){}
                
            }.AsQueryable();

            var mockSet = new Mock<Cars>();
            mockSet.As<IQueryable<Cars>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Cars>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Cars>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Cars>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<>();
            mockContext.Setup(c => c.Products).Returns(mockSet.Object);

            var service = new (mockContext.Object);
            var blogs = service.GetAllBlogs();

            Assert.AreEqual(3, blogs.Count);
            */
        }
    }
}
