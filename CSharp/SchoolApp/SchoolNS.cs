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

        public double AvgScore { get => _avgScore; }

        private double calculateAvgGrade() { return (_english + _maths + _french + _computing) * 0.25; }

        private char GetLetterGrade(){
            return AvgScore switch {
                >= 90 and <= 100 => 'A',
                >= 80 and <   90 => 'B',
                >= 70 and <   80 => 'C',
                >= 60 and <   70 => 'D',
                          <   60 => 'F',
                               _ => '_'
            };
        }

        public string displayGrades(){
            return $"\nScores: {_english}, {_maths}, {_french}, {_computing}\nAverage: {_avgScore}\nGrade: {_avgGrade}";
        }
    }

    class Student {
        public Student(string _F, GradesSet _G) {
            _firstName = _F;
            _grades = _G;
        }

        string _firstName = "default";

        GradesSet _grades;

        public string FirstName { get => _firstName; set => _firstName = value; }

        public void printStudent() { 
            Console.WriteLine(_firstName + _grades.displayGrades() + "\n");
        }
    }
}