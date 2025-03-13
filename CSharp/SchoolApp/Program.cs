
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Student Grade Management System \n===============================\n");

        // Sample student data
        List<string> studentNames = new List<string> { "Alex", "Taylor", "Jordan" };
        List<List<int>> studentScores = new List<List<int>> {
            new List<int> {95, 88, 92, 85},
            new List<int> {78, 81, 74, 70},
            new List<int> {62, 67, 69, 64}
        };

        List<School.Student> Pupils = studentNames.Select((name, index) => 
                                        new School.Student(name, new School.GradesSet(studentScores[index]))).ToList();

        Pupils.ForEach(pupil => pupil.printStudent());
        School.Student highestPupil = Pupils.OrderByDescending(Pupils => Pupils.Grades.AvgScore).First();
        School.Student lowestPupil = Pupils.OrderBy(Pupils => Pupils.Grades.AvgScore).First();

        Console.WriteLine("===============================");
        Console.WriteLine($"Class Average: {Pupils.Average(Pupils => Pupils.Grades.AvgScore)}"
                        + $"\nHighest Average: {highestPupil.FirstName} ({highestPupil.Grades.AvgScore})"
                        + $"\nLowest Average:   {lowestPupil.FirstName} ({lowestPupil.Grades.AvgScore })");
    }
}