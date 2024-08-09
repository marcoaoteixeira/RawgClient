using System.Web;

namespace Nameless.RawgClient.Helpers {
    internal static class EndpointHelper {
        internal static string CreateUri(Uri baseUri, string endpoint, Dictionary<string, object[]> queryParams) {
            var builder = new UriBuilder(baseUri) {
                Path = endpoint,
            };

            var queryString = HttpUtility.ParseQueryString(baseUri.Query);
            foreach (var queryParam in queryParams) {
                queryString.Add(name: queryParam.Key,
                                value: string.Join(',', queryParam.Value));
            }
            builder.Query = queryString.ToString();

            return builder.Uri.AbsoluteUri;
        }
    }
}
