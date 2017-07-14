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
        public IonicWebClient(string apiKey) :base()
        {
            this.BaseAddress = new Uri("https://api.ionic.io");
            this.DefaultRequestHeaders.Clear();
            this.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
