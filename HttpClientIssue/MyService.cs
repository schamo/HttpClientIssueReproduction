using System.Net.Http;

namespace HttpClientIssue
{
    public class MyService : IMyService
    {
        private readonly IMyOtherService _otherService;
        private readonly HttpClient _httpClient;

        public MyService(IMyOtherService otherService, HttpClient httpClient)
        {
            _otherService = otherService;
            _httpClient = httpClient;
        }

        public string GetData()
        {
            _otherService.GetDataFromWeb();
            return _httpClient.GetStringAsync("http://www.google.com").GetAwaiter().GetResult();
        }
    }
}
