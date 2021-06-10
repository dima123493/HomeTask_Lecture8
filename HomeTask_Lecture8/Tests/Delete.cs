using NUnit.Framework;
using Flurl.Http;
using HomeTask_Lecture8.Framework;

namespace HomeTask_Lecture8.Tests
{
    [TestFixture]
    class Delete
    {
        [Test]

        public void DeleteStatus()
        {
            var response = Settings.GetUrl().DeleteAsync().Result;

            Assert.AreEqual(200, response.StatusCode);
        }
    }
}