namespace Poczatki
{
    public class EmployeeInFile : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                    
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Invalid grade value");
                }
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
            var counter = 0;

            if(File.Exists(fileName))
            {
                using( var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        stats.Max = Math.Max(stats.Max, number);
                        stats.Min = Math.Min(stats.Min, number);
                        stats.Average += number;
                        counter++;
                        line = reader.ReadLine();
                    }
                }
                stats.Average /= counter;
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

                
            }
            return stats;
        }
        
        //public override Statistics GetStatistics()
        //{
        //    var gradesFromFile = ReadGradesFromFile();
        //    var result = CountStatistics(gradesFromFile);
        //    return result;
        //}
        //private List<float> ReadGradesFromFile()
        //{
        //    var grades = new List<float>();
        //    if (File.Exists($"{fileName}"))
        //    {
        //        using (var reader = File.OpenText($"{fileName}"))
        //        {
        //            var line = reader.ReadLine();
        //            while (line != null)
        //            {
        //                var number = float.Parse(line);
        //                grades.Add(number);
        //                line = reader.ReadLine();

        //            }
        //        }
        //    }
        //    return grades;
        //}
        //private Statistics CountStatistics(List<float> grades)
        //{
        //    var stats = new Statistics();
        //    stats.Average = 0;
        //    stats.Max = float.MinValue;
        //    stats.Min = float.MaxValue;

        //    foreach (var grade in grades)
        //    {
        //        stats.Max = Math.Max(stats.Max, grade);
        //        stats.Min = Math.Min(stats.Min, grade);
        //        stats.Average += grade;
        //    }
        //    stats.Average /= grades.Count;
        //    switch (stats.Average)
        //    {
        //        case var average when average >= 80:
        //            stats.AverageLetter = 'A';
        //            break;
        //        case var average when average >= 60:
        //            stats.AverageLetter = 'B';
        //            break;
        //        case var average when average >= 40:
        //            stats.AverageLetter = 'C';
        //            break;
        //        case var average when average >= 20:
        //            stats.AverageLetter = 'D';
        //            break;
        //        default:
        //            stats.AverageLetter = 'E';
        //            break;
        //    }

        //    return stats;
        //}
    }
        
    
}

           
    
          
    
            
    


            
           
            