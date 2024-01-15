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
        public void TestGetApiRequestStatsistics_ReturnsStatistics()
        {
            var client = new OpenUVClient(_apiKey);
            ApiStatistics stats = client.GetApiRequestStatistics().Result;

            Assert.IsNotNull(stats);
            Assert.IsTrue(stats.RequestsToday >= 0);
            Assert.IsTrue(stats.RequestsYesterday >= 0);
            Assert.IsTrue(stats.CostThisMonth >= 0);
            Assert.IsTrue(stats.CostLastMonth >= 0);
        }

        [TestMethod]
        public void TestGetApiRequestStatsistics_InvalidApiKey_ReturnsError()
        {
            try
            {
                var client = new OpenUVClient("");
                ApiStatistics stats = client.GetApiRequestStatistics().Result;
                Assert.Fail("This test case should not go here");
            }
            catch (AggregateException ex)
            {
                Assert.IsInstanceOfType(ex.InnerException, typeof(HttpRequestException));
            }
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
            Assert.IsTrue(uvInvexStat.SunInfo.SunPosition.Altitude != 0);
            Assert.IsTrue(uvInvexStat.SunInfo.SunPosition.Azimuth != 0);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunTimes);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunTimes.Dusk);
            Assert.IsNotNull(uvInvexStat.SunInfo.SunTimes.SolarNoon);
            Assert.IsTrue(uvInvexStat.UV >= 0);
            Assert.IsTrue(uvInvexStat.UVMax >= 0);
            Assert.IsNotNull(uvInvexStat.UVTime);
        }

        [TestMethod]
        public void TestGetUVIndexStatistics_InvalidApiKey_ReturnsError()
        {
            try
            {
                var client = new OpenUVClient("");
                UVIndexStatistics uvInvexStat = client.GetUVIndexStatistics(36.16, 139.11).Result;
                Assert.Fail("This test case should not go here");
            }
            catch (AggregateException ex)
            {
                Assert.IsInstanceOfType(ex.InnerException, typeof(HttpRequestException));
            }
        }

        [TestMethod]
        public void TestGetUVIndexForecast_ReturnListOfUVIndexForecasts()
        {
            var client = new OpenUVClient(_apiKey);
            List<UVIndexForecast> uvIndexForecasts = client.GetUVIndexForecast(36.16, 139.11).Result;

            Assert.IsNotNull(uvIndexForecasts);
            Assert.IsTrue(uvIndexForecasts.Count > 0);
            Assert.IsNotNull(uvIndexForecasts[0].SunPosition); 
            Assert.IsTrue(uvIndexForecasts[0].SunPosition.Azimuth != 0);
            Assert.IsTrue(uvIndexForecasts[0].UV >= 0);
        }

        [TestMethod]
        public void TestGetUVIndexForecast_InvalidApiKey_ReturnError()
        {
            try
            {
                var client = new OpenUVClient("");
                List<UVIndexForecast> uvIndexForecasts = client.GetUVIndexForecast(36.16, 139.11).Result;
                Assert.Fail("This test case should not go here");
            }
            catch (AggregateException ex)
            {
                Assert.IsInstanceOfType(ex.InnerException, typeof(HttpRequestException));
            }
        }
    }
}