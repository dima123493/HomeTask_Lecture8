using Flurl.Http;
using NUnit.Framework;
using HomeTask_Lecture8.Framework;

namespace HomeTask_Lecture8.Tests
{
    [TestFixture]
    class Get
    {
        [Test]
        public void GetStatus()
        {
            Framework.Models.Get getModel = new()
            {
                Title = "Dmytro Zubenko",
                Body = "Student",
                Id = "1234",
                UserId = "1234",
            };

            var response = Settings.GetUrl().GetAsync().Result;
            _ = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(200, response.StatusCode);
        }
    }
}
