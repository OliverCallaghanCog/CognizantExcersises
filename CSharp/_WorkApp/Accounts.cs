class WorkProgram {
    public static void StartFunc() {
        Console.WriteLine("Student Grade Management System \n===============================\n");

        // Sample student data
        List<string> studentNames = new List<string> { "Oli", "Toby", "Jordan" };
        List<List<byte>> studentScores = new List<List<byte>> {
            new List<byte> {95, 88, 92, 85},
            new List<byte> {78, 81, 74, 70},
            new List<byte> {62, 67, 69, 64}
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