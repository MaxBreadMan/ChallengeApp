using System.Reflection.Metadata;

namespace ChallengeApp1.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGetStatistic_ShouldReturnCorrectMaxMinAverageGrade()
        {
            //arrange
            var Employee = new Employee("Adam", "Nowak", "0 lat");
            Employee.AddGrade(2);
            Employee.AddGrade(2);
            Employee.AddGrade(6);

            //act
            var statistics = Employee.GetStatistics();

            // assert
            Assert.That(statistics.Max, Is.EqualTo(6));
            Assert.That(statistics.Min, Is.EqualTo(2));
            Assert.That(Math.Round(statistics.Average, 2), Is.EqualTo(Math.Round(3.33, 2)));
        }
        [Test]
        public void WhenEmpGetMixGrade_ShouldReturnCorrectAVGLetterGrade()
        {
            //arrange
            var Employee = new Employee("Monika", "Kowalska", "10 lat");
            Employee.AddGrade(100);
            Employee.AddGrade('D');
            Employee.AddGrade('c');
            Employee.AddGrade(100);

            //act
            var statistics = Employee.GetStatistics();

            //assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('B'));
        }

        [Test]
        public void WhenEmpGetMixGrade_ShouldReturnCorrectAVGGrade()
        {
            //arrange
            var Employee = new Employee("Monika", "Kowalska", "10 lat");
            Employee.AddGrade(36);
            Employee.AddGrade('D');
            Employee.AddGrade('c');
            Employee.AddGrade(0.76);

            //act
            var statistics = Employee.GetStatistics();

            //assert
            Assert.That(Math.Round(statistics.Average, 2), Is.EqualTo(Math.Round(34.19, 2)));
        }

    }
}