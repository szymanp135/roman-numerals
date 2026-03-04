using System.Text.RegularExpressions;

namespace romanNumeralsTDD;

public static class RomanConverter
{
    private static List<(string, int)> mapList = new List<(string, int)>
    {
        ("C", 100),
        ("XC", 90),
        ("L", 50),
        ("XL", 40),
        ("X", 10),
        ("IX", 9),
        ("V", 5),
        ("IV", 4),
        ("I", 1)
    };
    
    public static string Convert(int value)
    {
        int used = -1;
        string result = "";

        for (int i = 0; i < mapList.Count; i++)
        {
            if (value >= mapList[i].Item2)
            {
                if (i < used)
                {
                    return "";
                }
                value -= mapList[i].Item2;
                result += mapList[i].Item1;
                i = -1;
            }
        }

        return result;
    }
}