namespace RCMS.Utils;

public class Sanitizer
{
    public string SanitizeInput(string input)
    {
        return input.Replace("'", "''");
    }
}