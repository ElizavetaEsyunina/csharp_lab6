using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    public interface IFraction
    {
        public void SetValue(int numerator, int denominator);
        public double GetDoubleValue();
    }
}
