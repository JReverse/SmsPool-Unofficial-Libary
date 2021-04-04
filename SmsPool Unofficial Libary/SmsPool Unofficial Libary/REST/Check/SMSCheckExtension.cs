using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsPool_Unofficial_Libary
{
    class SMSCheckExtension
    {
        [JsonProperty("message")]
        public static string _message { get; set; }
        public string Message
        {
            get { return _message; }
        }
        
        [JsonProperty("success")]
        public static int _successcode { get; set; }
        public int successcode
        {
            get { return _successcode; }
        }
    }
}
