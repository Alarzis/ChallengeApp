namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(uint grade);

        void AddGrade(long grade);

        void AddGrade(ulong grade);

        void AddGrade(decimal grade);

        void AddGrade(char grade);

        Statistics GetStatistics();


    }
}
