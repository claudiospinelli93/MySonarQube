using System;
using Moq.AutoMock;
using Xunit;

namespace Service.Test
{
    public class CalculatorTest
    {

        private readonly AutoMocker _mocker;
        private readonly Calculator _calculator;
        public CalculatorTest()
        {
            _mocker = new AutoMocker();

            _calculator = _mocker.CreateInstance<Calculator>();
        }
                [Fact]
        public void Sum_FailValue_Exception()
        {
            // arrange
            int value1 = -2;
            int value2 = 3;

            // act/assert
            var exception = Assert.Throws<Exception>(() => _calculator.Sum(value1, value2));
            Assert.Equal("Field value1 or value2 less than 0.", exception.Message);
        }      
    }
}
