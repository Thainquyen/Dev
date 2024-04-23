using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public class SearchUser
    {

        private readonly HttpClient _client;
        public SearchUser()
        {
            _client = new HttpClient();
        }
        public async void searchUser(string val)
        {
            string apiUrl = Constant.GET_SEARCH_USER_API;
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

            // Add request body if needed
            string requestBody = "{\"val\": \"@val@\", \"_token\": \"@_token@\", \"_agent_id\": \"1\"}"; // Example JSON request body
            requestBody = requestBody.Replace("@val@", val);
            requestBody = requestBody.Replace("@_token@", Common.token);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.SendAsync(request);

            string responseBody = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(responseBody);
            int error = (int)jObject["err"];
            JObject jObject1 = (JObject)jObject["data"];

            JArray jarr = jObject1["data"].ToObject<JArray>();

            if (error == 0 && jarr.Count > 0)
            {
                Common.search_friend = jarr;
            }
        }
    }
}
