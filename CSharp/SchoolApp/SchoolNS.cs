namespace School {
    class GradesSet{
        public GradesSet(List<int> _G){
            _grades = _G;
            AvgScore = CalculateAvgGrade();
        }

        private List<int> _grades;
        public double AvgScore { get; }

        private double CalculateAvgGrade() => _grades.Average();
        private char GetLetterGrade() => AvgScore switch {
            >= 90 and <= 100 => 'A',
            >= 80 and <   90 => 'B',
            >= 70 and <   80 => 'C',
            >= 60 and <   70 => 'D',
                      <   60 => 'F',
                           _ => '_'
        };
        
        public string DisplayGrades() => $"\nScores: {string.Join(", ", _grades)}\nAverage: {AvgScore}\nGrade: {GetLetterGrade()}";
    }

    class Student {
        public Student(string _F, GradesSet _G) {
            FirstName = _F;
            Grades = _G;
        }

        public string FirstName { get; } // Auto Implemented Private members
        internal GradesSet Grades { get; }
        public void printStudent() => Console.WriteLine($"{FirstName}{Grades.DisplayGrades()}\n");
    }
}