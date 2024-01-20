namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
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
                throw new Exception($"Podana wartość {grade} jest nieprawidłowa");
            }
        }

        public void AddGrade(string grade)
        {
            var schoolGrade = new[] { "1", "+1", "1+", "-2", "2-", "2", "+2", "2+", "-3", "3-", "3", "+3", "3+", "-4", "4-", "4", "+4", "4+", "-5", "5-", "5", "+5", "5+", "-6", "6-", "6" };
            if (schoolGrade.Contains(grade))
            {
                switch (grade)
                {
                    case "6":
                        AddGrade(100);
                        break;
                    case "-6":
                    case "6-":
                        AddGrade(95);
                        break;
                    case "+5":
                    case "5+":
                        AddGrade(90);
                        break;
                    case "5":
                        AddGrade(85);
                        break;
                    case "-5":
                    case "5-":
                        AddGrade(80);
                        break;
                    case "+4":
                    case "4+":
                        AddGrade(75);
                        break;
                    case "4":
                        AddGrade(70);
                        break;
                    case "-4":
                    case "4-":
                        AddGrade(65);
                        break;
                    case "+3":
                    case "3+":
                        AddGrade(60);
                        break;
                    case "3":
                        AddGrade(50);
                        break;
                    case "-3":
                    case "3-":
                        AddGrade(40);
                        break;
                    case "+2":
                    case "2+":
                        AddGrade(30);
                        break;
                    case "2":
                        AddGrade(20);
                        break;
                    case "-2":
                    case "2-":
                        AddGrade(10);
                        break;
                    case "+1":
                    case "1+":
                        AddGrade(5);
                        break;
                    case "1":
                        AddGrade(0);
                        break;
                    default:
                        throw new Exception($"{grade} to nieprawidłowa ocena");
                }
            }
            else if (float.TryParse(grade, out float result))
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

            switch (statistics.Average)
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
