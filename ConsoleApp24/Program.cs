// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        // პირველი წილადი 1/2
        Fraction fraction1 = new Fraction(1, 2);
        Console.WriteLine($"პირველი წილადი: {fraction1}");

        // მეორე წილადი 1/3
        Fraction fraction2 = new Fraction(1, 3);
        Console.WriteLine($"მეორე წილადი: {fraction2}");

        // წილადების შეკრება
        Fraction sum = fraction1 + fraction2;
        Console.WriteLine($"ჯამი: {sum}");

        // წილადების შედარება
        Console.WriteLine($"წილადები ტოლია? {fraction1 == fraction2}");
        Console.WriteLine($"წილადები არ არის ტოლი? {fraction1 != fraction2}");
    }
}