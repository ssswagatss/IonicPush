using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class NotificationOverviewErrorVM
    {
        /// <summary>
        /// The number of times this error code was seen
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The error code seen within this notification
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
