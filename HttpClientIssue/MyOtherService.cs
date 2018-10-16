using System.Net.Http;

namespace HttpClientIssue
{
    public class MyOtherService : IMyOtherService
    {
        private readonly HttpClient _httpClient;

        public MyOtherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string GetDataFromWeb()
        {
            return _httpClient.GetStringAsync("http://www.google.com").GetAwaiter().GetResult();
        }
    }
}
