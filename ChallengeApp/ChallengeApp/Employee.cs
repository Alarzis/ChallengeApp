using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
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
        public Statistics GetStatisticsWithFor()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;
            
            for (int i = 0; i < this.grades.Count; i++)
            {
                    statisctics.Max = Math.Max(statisctics.Max, grades[i]);
                    statisctics.Min = Math.Min(statisctics.Min, grades[i]);
                    statisctics.Average += grades[i];
            }

            statisctics.Average /= this.grades.Count;
            return statisctics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statisctics.Max = Math.Max(statisctics.Max, grade);
                statisctics.Min = Math.Min(statisctics.Min, grade);
                statisctics.Average += grade;
            }

            statisctics.Average /= this.grades.Count;
            return statisctics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            var i = 0;

            while (i < this.grades.Count)
            {
                statisctics.Max = Math.Max(statisctics.Max, grades[i]);
                statisctics.Min = Math.Min(statisctics.Min, grades[i]);
                statisctics.Average += grades[i];
                i++;
            }

            statisctics.Average /= this.grades.Count;
            return statisctics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            var i = 0;

            do
            {
                statisctics.Max = Math.Max(statisctics.Max, grades[i]);
                statisctics.Min = Math.Min(statisctics.Min, grades[i]);
                statisctics.Average += grades[i];
                i++;
            }

            while (i < this.grades.Count);
            statisctics.Average /= this.grades.Count;
            return statisctics;
        }
    }
}
