using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class NotificationOverviewVM
    {
        [JsonProperty("invalid")]
        public int Invalid { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("errors")]
        public NotificationOverviewErrorVM Error{ get; set; }
    }
}
