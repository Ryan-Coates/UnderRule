using CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnderRule.ApiGateway.Interface.APIEntities
{
    public class PlayerAPI
    {
        private readonly string path = "/player";
        private readonly HTTPRequester requester;

        public PlayerAPI(HTTPRequester requester)
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
        public async Task<Player> GetAsync(string authToken)
        {
            var response = await requester.Get(path, authToken);
            return JsonConvert.DeserializeObject<Player>(response);
        }
    }
}
