namespace School {
    class GradesSet{
        public GradesSet(){}
        public GradesSet(double _E, double _M){
            _english = _E;
            _maths = _M;
            _avgGrade = calculateAvgGrade();
        }

        double _english;
        double _maths;
        double _avgGrade;

        public double English { get => _english; set => _english = value; }
        public double Maths { get => _maths; set => _maths = value; }
        public double AvgGrade { get => _avgGrade; set => _avgGrade = value; }

        private double calculateAvgGrade() { return (_english + _maths) * 0.5; }
        
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


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            School.Student member = new School.Student("Oliver", "Callaghan", 23, new School.GradesSet(85.4, 89.3));

            member.Grades.English = 0.9;

            member.printStudent();

        }
    }
}