using NUnit.Framework;
using Flurl.Http;
using HomeTask_Lecture8.Framework.Models;
using HomeTask_Lecture8.Framework;


namespace HomeTask_Lecture8.Tests
{
    [TestFixture]
    class Post
    {
        [Test]
        public void PostStatus()
        {
            Put_Post postModel = new()
            {
                Title = "Dmytro Zubenko",
                Body = "Student",
                UserId = "1234",
            };

            var response = Settings.PostUrl().PostJsonAsync(postModel).Result;
            _ = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(201, response.StatusCode);
        }
    }
}
