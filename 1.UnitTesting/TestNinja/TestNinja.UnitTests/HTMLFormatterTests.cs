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
    public class HTMLFormatterTests
    {


        [Test]
        public void FormatBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //general => Fault
            // Assert.That(result, Does.StartWith("<strong>"));
            // Assert.That(result, Does.EndtWith("</strong>"));
            //Assert.That(result, Does.Contains("abc"));
        }
    }
}
