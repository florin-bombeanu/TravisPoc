using NUnit.Framework;

namespace TravisPOC
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void TestThatCalinIsInDb()
        {
            //arrange
            var repo = new Repository();

            //act
            var result = repo.FetchUserByName("Calin");

            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestThatMihaiIsNotInDb()
        {
            //arrange
            var repo = new Repository();

            //act
            var result = repo.FetchUserByName("Mihai");

            //assert
            Assert.That(result, Is.False);
        }
    }
}
