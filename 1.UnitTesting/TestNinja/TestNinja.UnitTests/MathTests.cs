using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math  _math;

        //In SetUp Mtheod we decalre global variables to use in test Methods (to evite redendancy)
        [SetUp]
        public void SetUp()
        {
             _math = new Fundamentals.Math();
        } 


        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
          
            var result = _math.Add(1, 2);
            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        [Ignore("A faire la semaine prochaine")]
        public void Add_WhenCalled_ReturnSumOfArguments_IgnoreThisTest()
        {

            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }



        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnGreaterArg(int a ,int b,int expected )
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }


        //[Test]
        //public void Max_WhenFirstArgIsGreater_ReturnFirstArg()
        //{
            
        //    var result = _math.Max(2, 1);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_WhenSecondArgIsGreater_ReturnSecondArg()
        //{
            
        //    var result = _math.Max(1, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_WhenArsAreEqual_ReturnSameArg()
        //{
           
        //    var result = _math.Max(2, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}


        [Test]
        public void getOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result=_math.GetOddNumbers(5);

            //general
          //  Assert.That(result,Is.Not.Empty);
            
          //Assert.That(result.Count(),Is.EqualTo(3));
            
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result,Is.EquivalentTo(new int[]{1,3,5 }));

            //autres exemples d'assert
            //Assert.That(result,Is.Ordered);
            //Assert.That(result,Is.Unique);
        }


    }
}
