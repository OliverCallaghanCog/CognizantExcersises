using System;
using System.Collections.Generic;

using School;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Grade Management System");
        Console.WriteLine("===============================\n");

        School.Student member = new School.Student("Oliver", "Callaghan", 23, new School.GradesSet(95, 88, 92, 85));
        member.printStudent();

        // Sample student data
        // List<string> studentNames = new List<string> { "Alex", "Taylor", "Jordan" };
        // List<List<int>> studentScores = new List<List<int>> {
        //     new List<int> {95, 88, 92, 85},
        //     new List<int> {78, 81, 74, 70},
        //     new List<int> {62, 67, 69, 64}
        // };

        // // TODO: Calculate averages and print each student's summary
        // for (int i = 0; i < studentScores.Count; i++)
        // {
        //     string studentName = studentNames[i];
        //     List<int> scores = studentScores[i];

        //     double average = CalculateAverage(scores); // TODO
        //     char letterGrade = GetLetterGrade(average); // TODO

        //     // TODO: Print student details clearly (name, scores, average, letter grade)
        // }

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