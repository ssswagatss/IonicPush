using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class Error
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("details")]
        public List<ErrorDetail> ErrorDetails { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ErrorDetail
    {
        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("error_type")]
        public string ErrorType { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors{ get; set; }
    }
}
