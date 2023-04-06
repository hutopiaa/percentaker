namespace Percentake.Math
{
    public class PercentCalculator
    {
        private const double ValueOf100 = 100.0;

        public double WhatIsPercentOfXValue(double percent, double x)
        {
            return (x * percent) / ValueOf100;
        }

        public double XIsWhatPercentOfY(double x,double y)
        {
            return (x * ValueOf100) / y;
        }

        public double XIsPercentOfWhat(double x, double percent)
        {
            return (x * ValueOf100) / percent;
        }

        public double WhatIsXIncreasedByPercent(double x, double percent)
        {
            return x * (ValueOf100 + percent) / ValueOf100;
        }

        public double WhatIsXDecreasedByPercent(double x, double percent)
        {
            return x * (ValueOf100 - percent) / ValueOf100;
        }
    }
}