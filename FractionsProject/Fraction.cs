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
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int newNum = f1.numerator * f2.denominator;
            int newDen = f1.denominator * f2.numerator;
            return new Fraction(newNum, newDen);
        }
        public void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }


    }
}
