using CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnderRule.ApiGateway.Interface.APIEntities
{
    public class RegistrationAPI
    {
        private readonly string path = "registration";
        private readonly HTTPRequester requester;

        public RegistrationAPI(HTTPRequester requester)
        {
            this.requester = requester;
        }

        public async Task<bool> PostAsync(RegistrationModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await requester.PostAsync(path, content);
            return response;
        }
    }
}
