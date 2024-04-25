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
    public class AddGroup
    {

        private readonly HttpClient _client;
        public AddGroup()
        {
            _client = new HttpClient();
        }
        public async Task<AddGroupResponse> AddUserGroup()
        {
            string apiUrl = Constant.ADD_GROUP_API;
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

            // Add request body if needed
            string requestBody = "{\"_token\": \"@_token@\", \"_agent_id\": \"1\", \"users\": \"@users@\", \"list_id\": \"0\"}"; // Example JSON request body
            requestBody = requestBody.Replace("@_token@", Common.token);

            string userList = string.Join(",", Common.selectedUserID);
            requestBody = requestBody.Replace("@users@", "[" + userList + "]");
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.SendAsync(request);

            string responseBody = await response.Content.ReadAsStringAsync();

            AddGroupResponse res = new AddGroupResponse();
            res = JsonConvert.DeserializeObject<AddGroupResponse>(responseBody);

            return res;
        }
    }
}
