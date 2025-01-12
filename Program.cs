using System;
using System.Collections.Generic;

public class Assignment
{
    // Part 1: MultiplesOf Function
    public static List<int> MultiplesOf(int start, int count)
    {
        List<int> multiples = new List<int>();
        for (int i = 1; i <= count; i++)
        {
            multiples.Add(start * i);
        }
        return multiples;
    }

    // Part 2: RotateListRight Function
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        int startIndex = data.Count - amount; // Calculate the starting index for rotation
        List<int> rotatedList = new List<int>();

        // Slice the list into two parts and combine them
        rotatedList.AddRange(data.GetRange(startIndex, amount));
        rotatedList.AddRange(data.GetRange(0, startIndex));

        return rotatedList;
    }

    public static void Main(string[] args)
    {
        // Test Part 1: MultiplesOf
        Console.WriteLine("Testing MultiplesOf:");
        List<int> multiples = MultiplesOf(3, 5);
        Console.WriteLine($"Multiples of 3 (count 5): {string.Join(", ", multiples)}"); 
        // Expected Output: 3, 6, 9, 12, 15

        // Test Part 2: RotateListRight
        Console.WriteLine("\nTesting RotateListRight:");
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> rotated = RotateListRight(data, 5);
        Console.WriteLine($"Rotated List (amount 5): {string.Join(", ", rotated)}");
        // Expected Output: 5, 6, 7, 8, 9, 1, 2, 3, 4

        rotated = RotateListRight(data, 3);
        Console.WriteLine($"Rotated List (amount 3): {string.Join(", ", rotated)}");
        // Expected Output: 7, 8, 9, 1, 2, 3, 4, 5, 6
    }
}
