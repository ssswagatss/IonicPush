﻿using IonicPush.CSharp.Models;
using IonicPush.CSharp.Models.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp
{
    public class Push
    {
        private  string _baseUrl = "https://api.ionic.io";
        private  string _apiKey;
        private  string _profile ="dev";

        /// <summary>
        /// Constructs a Push Object
        /// </summary>
        /// <param name="apiKey">Ionic IO API Key</param>
        public Push(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Constructs a Push Object
        /// </summary>
        /// <param name="apiKey">Ionic IO API Key</param>
        /// <param name="baseUrl">Ionic IO Base url</param>
        public Push(string apiKey,string baseUrl)
        {
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Constructs a Push Object
        /// </summary>
        /// <param name="apiKey">Ionic IO API Key</param>
        /// <param name="baseUrl">Ionic IO Base url</param>
        /// <param name="profile">Ionic IO Profile Name</param>
        public Push(string apiKey, string baseUrl,string profile)
        {
            _apiKey = apiKey;
            _baseUrl = baseUrl;
            _profile = profile;
        }

        public string BaseUrl {
            get {
                return _baseUrl;
            }
        }
        public string ApiKey
        {
            get
            {
                return _apiKey;
            }
        }
        public string Profile
        {
            get
            {
                return _profile;
            }
        }

    }
}
