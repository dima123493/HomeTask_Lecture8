using Flurl.Http;
using HomeTask_Lecture8.Framework;
using HomeTask_Lecture8.Framework.Models;
using NUnit.Framework;

namespace HomeTask_Lecture8.Tests
{
    [TestFixture]
    class Patch
    {
        [Test]
        public void PatchStatus()
        {
            Put_Post patchModel = new()
            {
                UserId = "4321",
            };

            var response = Settings.GetUrl().PatchJsonAsync(patchModel).Result;
            _ = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(200, response.StatusCode);
        }
    }
}
