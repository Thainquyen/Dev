using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public class BaseInfo
    {

        private readonly HttpClient _client;
        public BaseInfo()
        {
            _client = new HttpClient();
        }
        public async void GetBase()
        {
            string apiUrl = Constant.GET_BASE_API;
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

            // Add request body if needed
            string requestBody = "{\"_token\": \"@_token@\", \"_agent_id\": \"1\"}"; // Example JSON request body
            requestBody = requestBody.Replace("@_token@", Common.token);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.SendAsync(request);

            string responseBody = await response.Content.ReadAsStringAsync();

            BaseUserInfo baseUserInfo = new BaseUserInfo();
            baseUserInfo = JsonConvert.DeserializeObject<BaseUserInfo>(responseBody);

            Common.uId = baseUserInfo.data.user_info.id;
            Common.nickname = baseUserInfo.data.user_info.nickname;
            Common.image = baseUserInfo.data.user_info.photo;

        }
    }
}
