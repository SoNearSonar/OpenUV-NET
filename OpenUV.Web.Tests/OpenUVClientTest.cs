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
            ApiStatistics stats = client.GetApiRequestStats().Result;

            Assert.IsNotNull(stats);
            Assert.IsTrue(stats.RequestsToday >= 0);
            Assert.IsTrue(stats.RequestsYesterday >= 0);
            Assert.IsTrue(stats.CostThisMonth >= 0);
            Assert.IsTrue(stats.CostLastMonth >= 0);
        }

        [TestMethod]
        public void TestGetUVIndexStatistics_ReturnsUVIndexStatistics()
        {
            var client = new OpenUVClient(_apiKey);
            UVIndexStatistics uvInvexStat = client.GetUVIndexStatistics(36.16, 139.11).Result;

            Assert.IsNotNull(uvInvexStat);
            Assert.IsTrue(uvInvexStat.Ozone >= 0);
            Assert.IsNotNull(uvInvexStat.SafeExposureTimeList);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunPosition);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunPosition.Altitude);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunPosition.Azimuth);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunTimes);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunTimes.Dusk);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunTimes.SolarNoon);
            Assert.IsTrue(uvInvexStat.UV >= 0);
            Assert.IsTrue(uvInvexStat.UVMax >= 0);
            Assert.IsNotNull(uvInvexStat.UVTime);
        }
    }
}