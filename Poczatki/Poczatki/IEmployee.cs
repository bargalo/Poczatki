namespace Poczatki
{
    public interface IEmployee
    {
        string Name { get; }
        public string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(int grade);
        void AddGrade(double grade);
        Statistics GetStatistics();
    }
}
