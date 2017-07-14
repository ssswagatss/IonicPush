using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IonicPush.CSharp.Models
{
    public class Meta
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("version")]
        public string ApiVersion { get; set; }
    }
}
