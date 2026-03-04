namespace romanNumeralsTDD;

public class RomanTests
{
    private List<(int, string)> _testValues = new List<(int, string)>();

    public void AddTestValue(string expected, int value)
    {
        _testValues.Add((value, expected));
    }

    public void RunTests(bool addSampleTestValues = true)
    {
        if (addSampleTestValues)
        {
            AddTestValues10();
            AddTestValues100();
        }

        int i = 0;
        foreach (var t in _testValues)
        { 
            var (success, result) = TestConverter(t.Item2, t.Item1);
            Console.Write($"Test {(i++).ToString().PadLeft(2)}. " +
                          $"arg: {(t.Item1).ToString().PadLeft(3)}; " +
                          $"expected: {(t.Item2).ToString().PadLeft(10)}; " +
                          $"result: {(result).ToString().PadLeft(10)}; passed: ");
            Console.ForegroundColor = success ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(success);
            Console.ResetColor();
        }
    }

    private void AddTestValues10()
    {
        _testValues.Add((0, ""));
        _testValues.Add((1, "I"));
        _testValues.Add((2, "II"));
        _testValues.Add((3, "III"));
        _testValues.Add((4, "IV"));
        _testValues.Add((5, "V"));
        _testValues.Add((6, "VI"));
        _testValues.Add((7, "VII"));
        _testValues.Add((8, "VIII"));
        _testValues.Add((9, "IX"));
        _testValues.Add((10, "X"));
    }

    private void AddTestValues100()
    {
        _testValues.Add((11, "XI"));
        _testValues.Add((12, "XII"));
        _testValues.Add((13, "XIII"));
        _testValues.Add((14, "XIV"));
        _testValues.Add((19, "XIX"));
        _testValues.Add((20, "XX"));
        _testValues.Add((40, "XL"));
        _testValues.Add((49, "XLIX"));
        _testValues.Add((50, "L"));
        _testValues.Add((88, "LXXXVIII"));
        _testValues.Add((99, "XCIX"));
        _testValues.Add((100, "C"));
    }

    private (bool, string) TestConverter(string expectedResult, int value)
    {
        var result = RomanConverter.Convert(value);
        return (expectedResult == result, result);
    }
}