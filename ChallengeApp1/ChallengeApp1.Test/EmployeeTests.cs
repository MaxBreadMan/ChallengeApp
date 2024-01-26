using System.Reflection.Metadata;

namespace ChallengeApp1.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectPoints_ShouldReturnCorrectResult()
        {
            // arrange
            var Employee = new Employee("Adam", "adsadasda123412", "34");
            Employee.AddScore(-5);
            Employee.AddScore(-10);
            Employee.AddScore(-25);
            Employee.AddScore(-60);
            Employee.AddScore(-60);
            // act
            var result = Employee.Result;
            // assert
            Assert.AreEqual(-32, result);
        }

        [Test]
        public void WhenUserCollectPoints_ShouldReturnCorrectResult2()
        {
            // arrange
            var Employee = new Employee("Monika", "adsafd3412", "27");
            Employee.AddScore(5);
            Employee.AddScore(10);
            Employee.AddScore(55);
            Employee.AddScore(10);
            // act
            var result = Employee.Result;
            // assert
            Assert.AreEqual(20, result);
        }
        [Test]
        public void WhenUserCollectPoints_ShouldReturnCorrectResult3()
        {
            // arrange
            var Employee = new Employee("Tadeusz", "adgghtrsafd3412", "19");
            Employee.AddScore(5);
            Employee.AddScore(10);
            Employee.AddScore(-55);
            Employee.AddScore(10);
            Employee.AddScore(85);
            // act
            var result = Employee.Result;
            // assert
            Assert.AreEqual(11, result);
        }
    }
}