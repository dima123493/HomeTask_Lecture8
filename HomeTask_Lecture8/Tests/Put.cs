using NUnit.Framework;
using Flurl.Http;
using HomeTask_Lecture8.Framework.Models;
using HomeTask_Lecture8.Framework;


namespace HomeTask_Lecture8.Tests
{
    [TestFixture]
    class Put
    {
        [Test]
        public void PutStatus()
        {
            Put_Post putModel = new()
            {
                Title = "Dmytro Zubenko",
                Body = "Student",
                UserId = "1234",
            };

            var response = Settings.GetUrl().PutJsonAsync(putModel).Result;
            _ = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(200, response.StatusCode);
        }
    }
}
