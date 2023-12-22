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
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int newNum = f1.numerator * f2.denominator + f2.numerator *
           f1.denominator;
            int newDen = f1.denominator * f2.denominator;
            return new Fraction(newNum, newDen);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int newNum = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            int newDen = f1.denominator * f2.denominator;
            return new Fraction(newNum, newDen);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int newNum = f1.numerator * f2.numerator;
            int newDen = f1.denominator * f2.denominator;
            return new Fraction(newNum, newDen);
        }

    }
}
