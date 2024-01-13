using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenUV.Web.Models;

namespace OpenUV.Web.Tests
{
    [TestClass]
    public class OpenUVClientTest
    {
        private readonly string _apiKey = "";

        // Result may be false if the service is down so this test could fail by chance
        [Ignore]
        [TestMethod]
        public void TestGetApiStatus_ReturnsStatus()
        {
            var client = new OpenUVClient(_apiKey);
            bool status = client.GetApiStatus().Result;

            Assert.IsTrue(status);
        }

        [TestMethod]
        public void TestGetApiRequestStats_ReturnsStatistics()
        {
            var client = new OpenUVClient( _apiKey);
            Statistics stats = client.GetApiRequestStats().Result;

            Assert.IsNotNull(stats);
            Assert.IsTrue(stats.RequestsToday >= 0);
            Assert.IsTrue(stats.RequestsYesterday >= 0);
            Assert.IsTrue(stats.CostThisMonth >= 0);
            Assert.IsTrue(stats.CostLastMonth >= 0);
        }
    }
}