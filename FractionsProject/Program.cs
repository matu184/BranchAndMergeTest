namespace FractionsProject;
class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);
        
        Fraction sum = f1 + f2;
        Console.WriteLine(sum);

        Fraction diff = f1 - f2;
        Console.WriteLine(diff);

        Fraction prod = f1 * f2;
        Console.WriteLine(prod);

        Fraction quot = f1 / f2;
        Console.WriteLine(quot);

       

        Console.ReadLine();

    }
}
