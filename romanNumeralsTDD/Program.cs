namespace  romanNumeralsTDD;

public class Program
{
    static void Main(string[] args)
    {
        int ten = 10;
        string romanTen = RomanConverter.Convert(ten);
        Console.WriteLine($"Roman number: {romanTen}");
    }
}