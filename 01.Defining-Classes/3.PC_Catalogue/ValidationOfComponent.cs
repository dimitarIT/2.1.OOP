using System;

internal class ValidationOfComponent
{
    public static void IsStringEmpty(string value, string variable)
    {
        if (value.Length == 0)
        {
            throw new ArgumentNullException(variable + " -> value must not be empty");
        }
    }

    public static void IsNumberNegative(decimal value, string variable)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(variable + " -> value must be positive number");
        }
    }
}