namespace FractionsProject;
class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(1, 2);
        Console.WriteLine(f);
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);
        Console.WriteLine(f1 + f2); //Ausgabe 5/6
        Console.ReadLine();

    }
}
