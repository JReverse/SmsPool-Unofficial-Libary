using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace SmsPool_Unofficial_Libary
{
    public class SMSHttpClient
    {
        public string Api { get; set; } = "https://smspool.net/api/";

        public async Task<HttpResponseMessage> Send(string endpoint)
        {
            var webClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            });

            while (true)
            {
                try
                {
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/x-www-form-urlencoded");
                    HttpResponseMessage response =
                    await webClient.GetAsync(Api + endpoint);
                    return response;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
    }
}
