using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void readVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoService();
           var result= service.ReadVideoTitle(new FakeFileReader());

            Assert.That(result,Does.Contain("error").IgnoreCase);

        }
    }
}
