using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class NotificationVM
    {
        /// <summary>
        /// App ID the Notification belongs to.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Notification Config
        /// </summary>
        [JsonProperty("config")]
        public NotificationConfigVM Config { get; set; }


        /// <summary>
        /// Time of Notification creation
        /// </summary>
        [JsonProperty("created", ItemConverterType = typeof(JavaScriptDateTimeConverter))]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Notification Overview Schema
        /// </summary>
        [JsonProperty("overview")]
        public NotificationOverviewVM Overview{ get; set; }

        /// <summary>
        ///Current state of the Notication in regards to our processing pipeline.The final state is enqueued.This means the notification has been processed and is now in the process of generating Message objects.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Determines whether or not the Notification can be modified
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
