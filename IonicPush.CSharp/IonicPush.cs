using IonicPush.CSharp.Models;
using IonicPush.CSharp.Models.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp
{
    public class Push
    {
        private readonly string _baseUrl = "https://api.ionic.io";
        private readonly string _apiKey;

        public Push(string apiKey)
        {
            _apiKey = apiKey;
        }


        public async  Task<Result<List<DeviceToken>>> GetTokens()
        {
            Result<List<DeviceToken>> tokens = new Result<List<DeviceToken>>();
            using (IonicWebClient client=new IonicWebClient(_apiKey))
            {
                HttpResponseMessage response = await client.GetAsync("/push/tokens");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    tokens= JsonConvert.DeserializeObject<Result<List<DeviceToken>>>(jsonString);
                }
            }
            return tokens;
        }
    }
}
