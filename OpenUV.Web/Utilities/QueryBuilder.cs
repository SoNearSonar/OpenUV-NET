using System.Globalization;
using System.Text;

namespace OpenUV.Web.Utilities
{
    internal static class QueryBuilder
    {
        public static string FormatQueryParams(double latitude, double longitude, uint altitude, DateTime time)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("?lat=");
            sb.Append(latitude);
            sb.Append("&lng=");
            sb.Append(longitude);
            sb.Append("&alt=");
            sb.Append(altitude);
            sb.Append("&time=");
            sb.Append(time.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
