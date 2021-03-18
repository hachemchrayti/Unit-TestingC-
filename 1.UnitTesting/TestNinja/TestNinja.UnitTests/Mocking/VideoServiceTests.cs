using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _videoservice;
        private Mock<IFileReader> _mockfileReader;

        [SetUp]
        public void SetUp()
        {
            _mockfileReader = new Mock<IFileReader>();
            _videoservice = new VideoService(_mockfileReader.Object);
        }
        [Test]
        public void readVideoTitle_EmptyFile_ReturnError()
        {
            _mockfileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var result= _videoservice.ReadVideoTitle();
            Assert.That(result,Does.Contain("error").IgnoreCase);

        }
    }
}
