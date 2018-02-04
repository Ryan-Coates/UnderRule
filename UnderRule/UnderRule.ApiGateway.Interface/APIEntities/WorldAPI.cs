using CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnderRule.ApiGateway.Interface.APIEntities
{
    class WorldAPI
    {
        private readonly string customersPath = "/world";
        private readonly HTTPRequester requester;

        public WorldAPI(HTTPRequester requester)
        {
            this.requester = requester;
        }

        public async Task<World> GetAsync(string authToken)
        {
            var response = await requester.Get(customersPath, authToken);
            return JsonConvert.DeserializeObject<World>(response);
        }
    }
}
