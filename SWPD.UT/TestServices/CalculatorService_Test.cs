using System;
using SWPD.Service;

namespace SWPD.UT.TestServices
{
    [TestFixture]
    public class Calculator_Test
	{
        private ICalculatorService _calculatorService;

        [SetUp]
        public void Setup()
        {
            _calculatorService = new CalculatorService();
        }

        [Test]
        public void Test1()
        {
            Assert.That(_calculatorService.Add(2, 5), Is.EqualTo(5));
            Assert.That(_calculatorService.Add(4, 2), Is.EqualTo(6));
        }
    }
}

