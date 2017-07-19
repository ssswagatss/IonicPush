using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace IonicPush.CSharp.Models.Results
{
    public class DeviceTokenVM
    {
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("created",ItemConverterType = typeof(JavaScriptDateTimeConverter))]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("id")]
        public string TokenId { get; set; }

        [JsonProperty("invalidated", ItemConverterType = typeof(JavaScriptDateTimeConverter))]
        public DateTime? InvalidDate{ get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("valid")]
        public string IsValid { get; set; }
    }
}
