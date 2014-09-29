using System;

public struct Fraction
{
    private long numerator;

    private long denominator;

    public Fraction(long numerator, long denumerator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denumerator;
    }

    public long Numerator
    {
        get
        {
            return this.numerator;
        }
        set
        {
            this.numerator = value;
        }
    }

    public long Denominator
    {
        get
        {
            return this.denominator;
        }

        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator can not be zero!");
            }

            if (value < 0)
            {
                value *= -1;
                this.Numerator *= -1;
            }

            this.denominator = value;
        }
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        checked
        {
            long newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
            long newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        checked
        {
            long newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            long newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
    }

    public override string ToString()
    {
        return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
    }
}