using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    public class FractionDecorator : IFraction
    {
        private Fraction fraction;
        private double? cachedDoubleValue;

        public FractionDecorator(Fraction fraction)
        {
            this.fraction = fraction;
            cachedDoubleValue = null;
        }
        public void SetValue(int numerator, int denominator)
        {
            if (denominator == 0) throw new Exception("Знаменатель не может быть равен нулю");
            if (denominator < 0)
            {
                fraction.Numerator = -numerator;
                fraction.Denominator = Math.Abs(denominator);
            }
            else
            {
                fraction.Numerator = numerator;
                fraction.Denominator = denominator;
            }
            cachedDoubleValue = null;
        }
        public double GetDoubleValue()
        {
            if (cachedDoubleValue == null)
                cachedDoubleValue = (double)fraction.Numerator / fraction.Denominator;
            return Math.Round(cachedDoubleValue.Value, 3);
        }
    }
}
