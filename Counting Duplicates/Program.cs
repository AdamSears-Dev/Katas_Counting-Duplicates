using System;
using System.Collections.Generic;

/* I used a Dictionary<char, int> to store the count of each 
character in the string.It converts the input string to lowercase to perform 
a case-insensitive comparison. Then, it iterates over each character in the 
lowercase string, updating the count in the dictionary accordingly. After 
counting the occurrences of each character, the code loops through the values in the 
dictionary and increments the duplicateCount variable if the count is greater
than 1. It returns the total count of characters that occur more than once!
When you call the DuplicateCount method with a string, it will return the count
of distinct case-insensitive alphabetic characters and numeric digits that occur 
more than once in the input string. */


public class Program
{
    public static void Main()
    {
        string input = "aabBcde"; // Replace with your desired input string

        int result = Kata.DuplicateCount(input);
        Console.WriteLine($"Duplicate count: {result}");
    }
}