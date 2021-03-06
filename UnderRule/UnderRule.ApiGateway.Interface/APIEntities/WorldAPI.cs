﻿using CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnderRule.ApiGateway.Interface.APIEntities
{
    public class WorldAPI
    {
        private readonly string path = "/world";
        private readonly HTTPRequester requester;

        public WorldAPI(HTTPRequester requester)
        {
            this.requester = requester;
        }

        public async Task<World> GetAsync(int userId, string authToken)
        {
            var response = await requester.Get(path + "?id=" + userId, authToken);
            return JsonConvert.DeserializeObject<World>(response);
        }
    }
}
