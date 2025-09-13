using System;

namespace Lab_2_1
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int n1, int n2) {
            if (n2 == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = n1;
            Denominator = n2;

            Reduce();

        }

        public void Reduce()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        public void Add(Fraction application)
        {
            int numerator = this.Numerator * application.Denominator + application.Numerator * this.Denominator;
            int denominator = this.Denominator * application.Denominator;
            
            this.Numerator = numerator;
            this.Denominator = denominator;
            Reduce();
        }

        public Fraction Multiply(Fraction application)
        {
            return new Fraction(this.Numerator * application.Numerator, this.Denominator * application.Denominator);
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
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
    }
}
