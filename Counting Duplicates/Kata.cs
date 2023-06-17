using System;
using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        // Convert the string to lowercase for case-insensitive comparison
        string lowerCaseStr = str.ToLower();

        foreach (char c in lowerCaseStr)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        int duplicateCount = 0;
        foreach (int count in charCounts.Values)
        {
            if (count > 1)
            {
                duplicateCount++;
            }
        }

        return duplicateCount;
    }
}

