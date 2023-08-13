using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Extensions;
public static class StringExtensions
{
    public static string GetSubstringFile(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        int lastDotIndex = input.LastIndexOf('.');

        if (lastDotIndex != -1 && lastDotIndex < input.Length - 1)
        {
            return input.Substring(lastDotIndex);
        }

        return string.Empty;
    }
}