using Newtonsoft.Json;

namespace SmsPool_Unofficial_Libary
{
    class SMSCancelExtension
    {
            [JsonProperty("message")]
            public static string _message { get; set; }
            public string Message
            {
                get { return _message; }
            }
    }
}
