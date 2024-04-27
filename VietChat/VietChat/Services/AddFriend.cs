using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public class AddFriend
    {

        private readonly HttpClient _client;
        public AddFriend()
        {
            _client = new HttpClient();
        }
        public async Task<CommonMsg> FriendAddAction(FriendApplyInfo info)
        {
            string apiUrl = Constant.ADD_FRIEND_ACTION_API;
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

            // Add request body if needed
            string requestBody = "{\"_token\": \"@_token@\", \"_agent_id\": \"1\", \"apply_id\": \"@apply_id@\"}"; // Example JSON request body
            requestBody = requestBody.Replace("@_token@", Common.token);
            requestBody = requestBody.Replace("@apply_id@", info.id);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.SendAsync(request);

            string responseBody = await response.Content.ReadAsStringAsync();

            CommonMsg res = new CommonMsg();
            res = JsonConvert.DeserializeObject<CommonMsg>(responseBody);

            return res;
        }
    }
}
