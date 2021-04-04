using Newtonsoft.Json;

namespace SmsPool_Unofficial_Libary
{
    class SMSOrderExtension
    {
        [JsonProperty("message")]
        public static string _message { get; set; }
        public string Message
        {
            get { return _message; }
        }

        [JsonProperty("orderid")]
        public static string _orderid { get; set; }
        public string OrderID
        {
            get { return _orderid; }
        }

        [JsonProperty("number")]
        public static string _number { get; set; }
        public string Number
        {
            get { return _number; }
        }
    }
}
