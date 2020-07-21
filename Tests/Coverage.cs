using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    public class Coverage
    {
        [Test]
        public async Task TaskTest()
        {
            var obj = new Library.Class1();
            var result = await obj.TaskMethod();
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public async Task ValueTaskTest()
        {
            var obj = new Library.Class1();
            var result = await obj.ValueTaskMethod();
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
