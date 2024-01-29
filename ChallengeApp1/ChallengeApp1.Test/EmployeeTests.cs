using System.Reflection.Metadata;

namespace ChallengeApp1.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGetStatistic_ShouldReturnCorrectMaxMinAverageGrade()
        {
            // arrange
            var Employee = new Employee("Adam", "Kamizelich", "10 lat");
            Employee.AddGrade(2);
            Employee.AddGrade(2);
            Employee.AddGrade(6);
            Employee.AddGrade(8);

            // act
            var statistics = Employee.GetStatistics();

            // assert
            Assert.That(statistics.Max, Is.EqualTo(8));
            Assert.That(statistics.Min, Is.EqualTo(2));
            Assert.That(statistics.Average, Is.EqualTo(4.5));
        }
    }
}