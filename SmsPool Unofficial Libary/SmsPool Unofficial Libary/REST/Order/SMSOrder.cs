using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmsPool_Unofficial_Libary
{
    public static class SMSOrder
    {
        public static async Task<string> Order(this SMSClient client, string pool, string service, string country)
        {
            try {
            HttpResponseMessage post = await client.HttpClient.Send("order.php?api_key=" + client.Api_key + "&pool=" + pool + "&service=" + service + "&country=" + country);
            string results = await post.Content.ReadAsStringAsync();
            if (results.Contains("Please fill in your API key.")) { return "Please fill in your API key."; }
            SMSOrderExtension result = JsonConvert.DeserializeObject<SMSOrderExtension>(results);
            if (result.Message != null)
            {
                return result.Message;
            }
            if (result.OrderID != null)
            {
                client.Order_ID = result.OrderID;
                return result.Number;
            }
            return "Failed to order number.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
