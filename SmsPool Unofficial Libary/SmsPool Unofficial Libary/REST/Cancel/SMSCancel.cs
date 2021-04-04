using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmsPool_Unofficial_Libary
{
    public static class SMSCancel
    {
        public static async Task<string> Cancel(this SMSClient client, string order_id)
        {
            try
            {
                HttpResponseMessage post = await client.HttpClient.Send("check.php?api_key=" + client.Api_key + "&orderid=" + order_id + "&method=CANCEL");
                string results = await post.Content.ReadAsStringAsync();
                if (results.Contains("Please fill in your API key.")) { return "Please fill in your API key."; }
                SMSCancelExtension result = JsonConvert.DeserializeObject<SMSCancelExtension>(results);
                if (result.Message != null)
                {
                    return result.Message;
                }
                else { return "Failed to cancel order."; };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
