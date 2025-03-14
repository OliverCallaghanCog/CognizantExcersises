namespace School {
    class GradesSet{
        public GradesSet(List<byte> _G) {
            _grades = _G;
            AvgScore = CalculateAvgGrade();
        }

        private List<byte> _grades;
        public float AvgScore { get; }

        private float CalculateAvgGrade() => _grades.Select(b => (float)b).Average();
        private char GetLetterGrade() => AvgScore switch {
            >= 90 => 'A',
            >= 80 => 'B',
            >= 70 => 'C',
            >= 60 => 'D',
            _ => 'F'
        };

        public string GetGradesMSG() => $"\nScores: {string.Join(", ", _grades)}\nAverage: {AvgScore}\nGrade: {GetLetterGrade()}";
    }

    class Student {
        public Student(string _F, GradesSet _G) {
            FirstName = _F;
            Grades = _G;
        }

        public string FirstName { get; } // Auto Implemented Private members
        internal GradesSet Grades { get; }
        public void printStudent() => Console.WriteLine($"{FirstName}{Grades.GetGradesMSG()}\n");
    }
}