namespace SmsPool_Unofficial_Libary
{
    public class SMSClient
    {
        public string Api_key { get; set; }

        public string Order_ID { get; set; }

        public SMSHttpClient HttpClient { get; private set; }

        public SMSClient(string api_key)
        {
            Api_key = api_key;
        }

    }
}

