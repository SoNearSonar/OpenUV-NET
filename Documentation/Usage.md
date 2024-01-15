# Using OpenUV-NET
OpenUV-NET is a C# API wrapper for OpenUV's web API. It supports the following functions from the API:
- Getting status of the API.
- Getting API request statistics (how many requests were done and costs associated).
- Getting UV index statistics.
- Getting UV index forecasts.

# Get API key
Log into https://www.openuv.io/ to get a API key.

# Usage
Below are examples of API calls you can do with this client. 

## Status
```csharp
var client = new OpenUVClient("api_key");
bool status = await client.GetApiStatus();

Console.WriteLine(string.Format("API status: {0}", status));
```

## Request Statistics
```csharp
var client = new OpenUVClient("api_key");
var stats = await client.GetApiRequestStatistics();

Console.WriteLine(string.Format("Request done today ({0}), yesterday ({1}), and this month ({2})", stats.RequestsToday, stats.RequestsYesterday, stats.RequestsThisMonth));
```

## UV Index Statistics
```csharp
var client = new OpenUVClient("api_key");
var uvIndexStats = await client.GetUVIndexStatistics(36.16, 139.11);

Console.WriteLine(string.Format("Ozone product count (OMTO3) ({0}), UV index ({1}), sunrise ({2})", uvIndexStats.Ozone, uvIndexStats.UV, uvIndexStats.SunInfo.SunTimes.Sunrise));
```

## UV Index Forecast
```csharp
var client = new OpenUVClient("api_key");
var uvIndexForecasts = await client.GetUVIndexForecast(36.16, 139.11);
var forecast = uvIndexForecasts[0];

Console.WriteLine(string.Format("First forecast sunrise ({0}), UV level ({1}), sun altitude ({2})", forecast.Sunrise, forecast.UV, forecast.SunPosition.Altitude));
```