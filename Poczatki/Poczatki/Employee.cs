namespace Poczatki
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("string isnt float");
            }
        }
        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(decimal grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public Statistics GetStatisticsWithForEach()
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

            return stats;
        }
        public Statistics GetStatisticsWithFor()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            int i = 0;
            
            for (var grade = 0; grade < grades.Count; grade++)
            {
                stats.Max = Math.Max(stats.Max, grades[i]);
                stats.Min = Math.Min(stats.Min, grades[i]);
                stats.Average += grades[i];
                i++;
            }
            stats.Average /= grades.Count;

            return stats;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            int i= 0;

            do
            {
                stats.Max = Math.Max(stats.Max, grades[i]);
                stats.Min = Math.Min(stats.Min, grades[i]);
                stats.Average += grades[i];
                i++;
            }while(i < grades.Count);
            stats.Average /= grades.Count;

            return stats;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            int i = 0;

            while (i < grades.Count)
            {
                stats.Max = Math.Max(stats.Max, grades[i]);
                stats.Min = Math.Min(stats.Min, grades[i]);
                stats.Average += grades[i];
                i++;
            }
            stats.Average /= grades.Count;

            return stats;
        }
    }
}
