using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp
{
    public class IonicWebClient: HttpClient
    {
        public IonicWebClient(string apiKey,string baseUrl) :base()
        {
            this.BaseAddress = new Uri(baseUrl);
            this.DefaultRequestHeaders.Clear();
            this.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
