using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
   public  class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var errLogger = new ErrorLogger();
            errLogger.Log("a");
            Assert.That(errLogger.LastError,Is.EqualTo("a"));
        }


        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var errLogger = new ErrorLogger();
            Assert.That( ()=>
            {
              errLogger.Log(error);
            }, Throws.ArgumentNullException);
            //Assert.That(() =>
            //{
            //    errLogger.Log(error);
            //}, Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
