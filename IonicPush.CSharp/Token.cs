using IonicPush.CSharp.Models;
using IonicPush.CSharp.Models.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IonicPush.CSharp
{
    public class Token
    {
        private readonly Push _ionicPush;

        /// <summary>
        /// Constructor to create a Token Object
        /// </summary>
        /// <param name="ionicPush">Ionic Push Object</param>
        public Token(Push ionicPush)
        {
            _ionicPush = ionicPush;
        }

        public async Task<Result<List<DeviceTokenVM>>> GetTokens(bool? showInvalid, int? pageSize, int? page, string userId = "")
        {
            Result<List<DeviceTokenVM>> tokens = new Result<List<DeviceTokenVM>>();
            using (IonicWebClient client = new IonicWebClient(_ionicPush.ApiKey,_ionicPush.BaseUrl))
            {
                var query = HttpUtility.ParseQueryString("");
                if (showInvalid.HasValue)
                {
                    query["show_invalid"] = showInvalid.Value.ToString();
                }
                if (pageSize.HasValue)
                {
                    query["page_size"] = pageSize.Value.ToString();
                }
                if (page.HasValue)
                {
                    query["page"] = page.Value.ToString();
                }
                if (!string.IsNullOrEmpty(userId))
                {
                    query["user_id"] = userId.ToString();
                }

                string queryString = "/push/tokens?"+query?.ToString()??"";

                HttpResponseMessage response = await client.GetAsync(queryString);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    tokens = JsonConvert.DeserializeObject<Result<List<DeviceTokenVM>>>(jsonString);
                }
            }
            return tokens;
        }
    }
}
