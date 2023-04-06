using Percentake.Math;
using Percentake.Math.Extensions;

namespace Percentaker.Test
{
    public class PercentCalculatorTest
    {
        private readonly PercentCalculator _percentCalculator;

        public PercentCalculatorTest() { 
            _percentCalculator = new PercentCalculator();
        }

        [Theory]
        [InlineData(207.0, 50.0, 103.5)]
        [InlineData(111.00 , 100.0, 111.0)]
        public void Execute_WhatIsPercentOfXValue_AndValidateResult(double percent, double x, double resultShouldBe)
        {
            double testResult = _percentCalculator.WhatIsPercentOfXValue(percent, x).PercentRound();

            Assert.Equal(testResult, resultShouldBe);
        }

        [Theory]
        [InlineData(12.0, 50.0, 24)]
        [InlineData(73.0, 254.6, 28.6724)]
        public void Execute_XIsWhatPercentOfY_AndValidateResult(double x, double y, double resultShouldBe)
        {
            double testResult = _percentCalculator.XIsWhatPercentOfY(x, y).PercentRound();

            Assert.Equal(testResult, resultShouldBe);
        }

        [Theory]
        [InlineData(20.0, 12.0, 166.6667)]
        [InlineData(48.0, 3.21, 1495.3271)]
        public void Execute_XIsPercentOfWhat_AndValidateResult(double x, double percent, double resultShouldBe)
        {
            double testResult = _percentCalculator.XIsPercentOfWhat(x, percent).PercentRound();

            Assert.Equal(testResult, resultShouldBe);
        }

        [Theory]
        [InlineData(10.0, 100.0, 20.0)]
        [InlineData(11.11, 127.0, 25.2197)]
        public void Execute_WhatIsXIncreasedByPercent_AndValidateResult(double x, double percent, double resultShouldBe)
        {
            double testResult = _percentCalculator.WhatIsXIncreasedByPercent(x, percent).PercentRound();

            Assert.Equal(testResult, resultShouldBe);
        }

        [Theory]
        [InlineData(10.0, 100.0, 0.0)]
        [InlineData(11.11, 127.0, -2.9997)]
        public void Execute_WhatIsXDecreasedByPercent_AndValidateResult(double x, double percent, double resultShouldBe)
        {
            double testResult = _percentCalculator.WhatIsXDecreasedByPercent(x, percent).PercentRound();

            Assert.Equal(testResult, resultShouldBe);
        }
    }
}