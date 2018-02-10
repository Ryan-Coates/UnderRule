using CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public async Task<Player> GetAsync(string authToken)
        {
            var response = await requester.Get(path, authToken);
            return JsonConvert.DeserializeObject<Player>(response);
        }
    }
}
