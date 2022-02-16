using Microsoft.AspNetCore.Http;

namespace CSI_340_ChenRoblesWu_Website.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
        request.QueryString.HasValue
        ? $"{request.Path}{request.QueryString}"
        : request.Path.ToString();
    }
}
