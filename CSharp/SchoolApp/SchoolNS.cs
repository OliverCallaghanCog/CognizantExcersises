namespace School {
    class GradesSet{
        public GradesSet(){}
        public GradesSet(double _E, double _M, double _F, double _C){
            _english = _E;
            _maths = _M;
            _french = _F;
            _computing = _C;
            _avgScore = calculateAvgGrade();
            _avgGrade = GetLetterGrade();
        }

        double _english = 0;
        double _maths = 0;
        double _french = 0;
        double _computing = 0;
        double _avgScore = 0;
        char _avgGrade = '_';

        public double English { get => _english; set => _english = value; }
        public double Maths { get => _maths; set => _maths = value; }
        public double French { get => _french; set => _french = value; }
        public double Computing { get => _computing; set => _computing = value; }
        public double AvgScore { get => _avgScore; }

        public char AvgGrade { get => _avgGrade; }

        private double calculateAvgGrade() { return (_english + _maths + _french + _computing) * 0.25; }

        private char GetLetterGrade(){
            char grade = _avgScore switch {
                >= 90 and <= 100 => 'A',
                >= 80 and <   90 => 'B',
                >= 70 and <   80 => 'C',
                >= 60 and <   70 => 'D',
                < 60 => 'F',
                _ => throw new ArgumentOutOfRangeException(nameof(_avgScore), "Score must be between 0 and 100")
            };
            return grade;
        }

    }

    class Student {
        public Student(string _F, string _L, int _A, GradesSet _G) {
            _firstName = _F;
            _lastName = _L;
            _age = _A;
            _grades = _G;
        }

        string _firstName = "default";
        string _lastName = "default";
        int _age = 0;

        GradesSet _grades;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        internal GradesSet Grades { get => _grades; set => _grades = value; }

        public void printStudent() { Console.WriteLine(_firstName + "\n" + _lastName + "\n" + _age + "\n" + Grades.AvgGrade); }

    }
}