namespace Poczatki
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {}
        
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this,new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
                //Console.WriteLine("Invalid grade value");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter!");
                    //Console.WriteLine("Wrong letter!");
                    //break;
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                AddGrade(resultChar);
            }
            else
            {
                throw new Exception("String isnt float");
                //Console.WriteLine("String isnt float");
            }
        }

        public override void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average += grade;
            }
            stats.Average /= grades.Count;

            switch (stats.Average)
            {
                case var average when average >= 80:
                    stats.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    stats.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    stats.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    stats.AverageLetter = 'D';
                    break;
                default:
                    stats.AverageLetter = 'E';
                    break;
            }

            return stats;
        }
    }
}
