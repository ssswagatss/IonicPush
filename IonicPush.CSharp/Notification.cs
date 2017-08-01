using IonicPush.CSharp.Interfaces;
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
    public class Notification :INotification
    {

        private readonly Push _ionicPush;

        /// <summary>
        /// Constructor to create a Notification Object
        /// </summary>
        /// <param name="ionicPush">Ionic Push Object</param>
        public Notification(Push ionicPush)
        {
            _ionicPush = ionicPush;
        }
        public async Task<Result<List<CreatedNotificationVM>>> GetNotifications(int? pageSize, int? page)
        {
            Result<List<CreatedNotificationVM>> tokens = new Result<List<CreatedNotificationVM>>();
            using (IonicWebClient client = new IonicWebClient(_ionicPush.ApiKey, _ionicPush.BaseUrl))
            {
                var query = HttpUtility.ParseQueryString("");
                
                if (pageSize.HasValue)
                {
                    query["page_size"] = pageSize.Value.ToString();
                }
                if (page.HasValue)
                {
                    query["page"] = page.Value.ToString();
                }

                string queryString = "/push/notifications?" + query?.ToString() ?? "";

                HttpResponseMessage response = await client.GetAsync(queryString);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    tokens = JsonConvert.DeserializeObject<Result<List<CreatedNotificationVM>>>(jsonString);
                }
            }
            return tokens;
        }

        public async Task<Result<CreatedNotificationVM>> SendNotificationsToDevices(List<string> tokens,string heading, string message)
        {
            if (string.IsNullOrEmpty(_ionicPush.Profile))
            {
                throw new Exception("Ionic IO Profile is not provided.");
            }
            Result<CreatedNotificationVM> token = new Result<CreatedNotificationVM>();
            using (IonicWebClient client = new IonicWebClient(_ionicPush.ApiKey, _ionicPush.BaseUrl))
            {
                var postData = new {
                    tokens=tokens,
                    profile=_ionicPush.Profile,
                    notification = new
                    {
                        message=message,
                        heading=heading
                    }
                };
                //var myContent = JsonConvert.SerializeObject(postData);
                HttpResponseMessage response = await client.PostAsJsonAsync("/push/notifications", postData);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    token = JsonConvert.DeserializeObject<Result<CreatedNotificationVM>>(jsonString);
                }
            }
            return token;
        }


        public async Task<Result<CreatedNotificationVM>> SendNotificationsToAll(string heading, string message)
        {
            if (string.IsNullOrEmpty(_ionicPush.Profile))
            {
                throw new Exception("Ionic IO Profile is not provided.");
            }
            Result<CreatedNotificationVM> token = new Result<CreatedNotificationVM>();
            using (IonicWebClient client = new IonicWebClient(_ionicPush.ApiKey, _ionicPush.BaseUrl))
            {
                var postData = new
                {
                    send_to_all=true,
                    profile = _ionicPush.Profile,
                    notification = new
                    {
                        message = message,
                        title = heading
                    }
                };
                //var myContent = JsonConvert.SerializeObject(postData);
                HttpResponseMessage response = await client.PostAsJsonAsync("/push/notifications", postData);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    token = JsonConvert.DeserializeObject<Result<CreatedNotificationVM>>(jsonString);
                }
            }
            return token;
        }
    }
}
