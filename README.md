# Exercise: Student Grade Calculator in C#

## Objective
Create a C# console application that calculates student grades and class averages, applying your knowledge of variables, data types, loops, conditionals, methods (functions), and lists.

---

## Requirements

You will build a simple console application that manages student grades. Your application should:

- Store each student’s name and their scores.
- Calculate each student’s average score.
- Assign each student a letter grade based on their average:
  - `A`: 90–100
  - `B`: 80–89
  - `C`: 70–79
  - `D`: 60–69
  - `F`: Below 60
- Print a clear summary showing each student's name, scores, average, and letter grade.
- Calculate and print:
  - The overall class average.
  - The highest-scoring student's name and average.
  - The lowest-scoring student's name and average.

---

## Starter Code

Below is incomplete starter code. Your task is to complete the methods and logic clearly marked with `// TODO`.

### `Program.cs`

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Grade Management System");
        Console.WriteLine("===============================\n");

        // Sample student data
        List<string> studentNames = new List<string> { "Alex", "Taylor", "Jordan" };
        List<List<int>> studentScores = new List<List<int>> {
            new List<int> {95, 88, 92, 85},
            new List<int> {78, 81, 74, 70},
            new List<int> {62, 67, 69, 64}
        };

        // TODO: Calculate averages and print each student's summary
        for (int i = 0; i < studentScores.Count; i++)
        {
            string studentName = studentNames[i];
            List<int> scores = studentScores[i];

            double average = CalculateAverage(scores); // TODO
            char letterGrade = GetLetterGrade(average); // TODO

            // TODO: Print student details clearly (name, scores, average, letter grade)
        }

        // TODO: Compute and print class statistics:
        // - Class average
        // - Highest scoring student
        // - Lowest scoring student
    }

    // TODO: Method to calculate the average score from a list of integers
    static double CalculateAverage(List<int> scores)
    {
        // Implement calculation here
    }

    // TODO: Method to determine the letter grade based on average score
    static char GetLetterGrade(double average)
    {
        // Implement logic here
    }

    // Optional additional methods for class average, highest, and lowest scores
}
```

---

## Expected Output

When completed correctly, your output will look like this:

```
Student Grade Management System
===============================

Alex
Scores: 95, 88, 92, 85
Average: 90.0
Grade: A

Taylor
Scores: 78, 81, 74, 70
Average: 75.8
Grade: C

Jordan
Scores: 62, 67, 69, 64
Average: 65.5
Grade: D

===============================
Class Average: 77.1
Highest Average: Alex (90.0)
Lowest Average: Jordan (65.5)
```

---

## Hints:

- Use loops (`for`, `foreach`) to iterate through arrays or lists.
- Separate each calculation into its own method clearly.
- Use conditional statements (`if-else`) to determine letter grades.
- You can format strings easily with:
  ```csharp
  Console.WriteLine($"Hello {name}, your average is {average}");
  ```
- Optionally, handle edge cases, such as empty lists, gracefully.

---

## Evaluation Criteria:

- Correct calculation of averages.
- Accurate assignment of letter grades.
- Correct usage of loops, conditionals, and methods.
- Clear, readable, and organized code.

---
