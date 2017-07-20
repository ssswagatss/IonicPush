using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class NotificationConfigVM
    {
        /// <summary>
        /// Android Notification Options
        /// </summary>
        [JsonProperty("android")]
        public AndroidNotificationConfigVM Android{ get; set; }

        /// <summary>
        /// iOS Notification Options
        /// </summary>
        [JsonProperty("ios")]
        public IOSNotificationConfigVM IOS{ get; set; }
        /// <summary>
        ///Message Text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Custom data
        /// </summary>
        [JsonProperty("payload")]
        public object Payload { get; set; }

        /// <summary>
        /// Notification Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
