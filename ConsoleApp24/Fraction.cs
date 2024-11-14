public class Fraction
{
    // მრიცხველი და მნიშვნელი
    private int _numerator;
    private int _denominator;


    public Fraction(int numerator, int denominator)
    {
        // ვამოწმებთ მნიშვნელი არ არის თუ არა 0
        if (denominator == 0)
        {
            throw new Exception("მნიშვნელი არ შეიძლება იყოს 0!");
        }

        _numerator = numerator;
        _denominator = denominator;
    }


    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // ორი წილადის შეკრება
    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNumerator = (a._numerator * b._denominator) + (b._numerator * a._denominator);
        int newDenominator = a._denominator * b._denominator;

        return new Fraction(newNumerator, newDenominator);
    }

    // წილადების შედარება (ტოლია თუ არა)
    public static bool operator ==(Fraction a, Fraction b)
    {
        return a._numerator == b._numerator && a._denominator == b._denominator;
    }

    // წილადების შედარება (არ არის ტოლი)
    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }
}




