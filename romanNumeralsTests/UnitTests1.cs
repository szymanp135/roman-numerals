namespace romanTests;

public class UnitTests1
{
    [Fact]
    public void RomanTests10()
    {
        RomanTests romanTests = new RomanTests();
        romanTests.AddTestValues10();
        Console.WriteLine($"\nTesting values 1-10:");
        romanTests.RunTests();
    }
    
    [Fact]
    public void RomanTests100()
    {
        RomanTests romanTests = new RomanTests();
        romanTests.AddTestValues100();
        Console.WriteLine($"\nTesting values 11-100:");
        romanTests.RunTests();
    }
}