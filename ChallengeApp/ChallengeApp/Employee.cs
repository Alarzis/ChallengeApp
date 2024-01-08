using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private const char sex ='M';

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
           this.name = name;
           this.surname = surname;
        }

        public string name { get; private set; }

        public string surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"Podana wartość {grade} jest nieprawidłowa");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (char.TryParse(grade, out char result2))
            {
                AddGrade(result2);
            }    
            else
            {
                throw new Exception($"String {grade} is not float");
            }
        }

        public void AddGrade(double grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        public void AddGrade(int grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        public void AddGrade(uint grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        public void AddGrade(long grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        public void AddGrade(ulong grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        public void AddGrade(decimal grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public void AddGrade(char grade)
        {
            switch(grade)
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
                    throw new Exception($"{grade} to nieprawidłowa litera");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            
            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            
            return statistics;
        }
    }
}
