using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsProject
{
    internal class Fraction
    {
        int numerator;
        int denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
