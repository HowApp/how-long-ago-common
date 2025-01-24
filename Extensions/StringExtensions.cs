using System;
using System.Text.RegularExpressions;

namespace HowCommon.Extensions;

public static class StringExtensions
{
    public static string ToSnake(this string income)
        {
            // Use regex to insert underscores before capital letters
            string snakeCase = Regex.Replace(income, "([a-z])([A-Z])", "$1_$2").ToLower();
            return snakeCase;
        }
}
