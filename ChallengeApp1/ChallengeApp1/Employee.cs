using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace ChallengeApp1
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, string seniority)
        {
            this.Name = name;
            this.Surname = surname;
            this.Seniority = seniority;
        }


        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Seniority { get; private set; }

        public void AddGrade(float grade)
        {
            // 3.99
            // 3
            int valueInInt = (int)grade;
            float f = (float)valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
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
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
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
            return statistics;
        }
    }
}
