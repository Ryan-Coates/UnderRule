﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UnderRule.ApiGateway.Interface
{
    public class HTTPRequester
    {
        private readonly HttpClient client;

        public HTTPRequester(string gatewayUrl)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(gatewayUrl);
        }

        internal async Task<bool> PostAsync(string path, HttpContent data)
        {

            var response = await client.PostAsync(path, data);

            //todo: validate response, retry
            return true;
        }

        internal async Task<string> Get(string path, string authToken)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

            var response = await client.GetAsync(path);

            //todo: validate response, retry

            var responseString = response.Content.ReadAsStringAsync().Result;

            return responseString;
            //return responseString;
        }

        internal async Task<string> Get(string path, int id, string authToken)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

            var response = await client.GetAsync(path+"/"+id);

            //todo: validate response, retry

            var responseString = response.Content.ReadAsStringAsync().Result;

            return responseString;
            //return responseString;
        }
    }
}
