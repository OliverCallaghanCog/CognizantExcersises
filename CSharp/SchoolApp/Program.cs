using System;
using System.Collections.Generic;

using School;

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

        List<School.Student> Pupils = new List<School.Student>();

        for (int i = 0; i < studentNames.Count; ++i){
            Pupils.Add(new School.Student(studentNames[i], new School.GradesSet(studentScores[i][0], studentScores[i][1], studentScores[i][2],studentScores[i][3])));
            Pupils[i].printStudent();
        }

        Console.WriteLine("===============================");
        Console.WriteLine("Class Average: \nHighest Average: \nLowest Average: ");


        // TODO: Compute and print class statistics:
        // - Class average
        // - Highest scoring student
        // - Lowest scoring student
    }

    // TODO: Method to calculate the average score from a list of integers
    static double CalculateAverage(List<int> scores)
    {
        // Implement calculation here
        return 0.0;
    }

    // TODO: Method to determine the letter grade based on average score
    static char GetLetterGrade(double average)
    {
        // Implement logic here
        return '_';
    }

    // Optional additional methods for class average, highest, and lowest scores
}