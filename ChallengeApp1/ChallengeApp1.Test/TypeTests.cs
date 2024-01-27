namespace ChallengeApp1
{
    public class TypeTests
    {
        [Test]
        public void IntShouldBeEqual()
        {
            // arrange
            int number1 = 6;
            int number2 = 7;
            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Adam", "dwvbewu4243");
            var user2 = GetUser("Monika", "dwvsd43");
            var user3 = GetUser("Przemek", "vnv74r47");
            // assert
            Assert.AreNotEqual(user1.Login, user1.Password, user2.Login, user2.Password, user3.Login, user3.Password);
        }
        [Test]
        public void FloatShouldBeNotEqual()
        {
            // arrange
            var number1 = 6.67;
            var number2 = 7.87;
            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void PasswordShouldBeNotEqual()
        {
            //arrange
            var user1 = GetUser("Monika", "qwe123");
            var user2 = GetUser("Monika", "123qwe");

            //assert

            Assert.AreNotEqual(user1.Password, user2.Password);
        }
        private User GetUser(string name, string password)
        {
            return new User(name, password);
        }
    }
}

