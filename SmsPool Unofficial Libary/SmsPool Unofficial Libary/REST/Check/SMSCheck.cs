using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmsPool_Unofficial_Libary
{
    public static class SMSCheck
    {
        public static async Task<string> Check(this SMSClient client, string order_id)
        {
            try
            {
                HttpResponseMessage post = await client.HttpClient.Send("check.php?api_key=" + client.Api_key + "&orderid=" + order_id + "&method=CHECK");
                string results = await post.Content.ReadAsStringAsync();
                if (results.Contains("Please fill in your API key.")) { return "Please fill in your API key."; }
                SMSCheckExtension result = JsonConvert.DeserializeObject<SMSCheckExtension>(results);
                if (result.successcode == 0)
                {
                    await client.Cancel(order_id);
                }
                else if (result.successcode == 1)
                {
                    return result.Message;
                }
                else if(result.successcode == 2)
                {
                    return "Waiting.";
                }
                else if(result.successcode == 3)
                {
                    await client.Cancel(order_id);
                }
                return "Failed to check order.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
