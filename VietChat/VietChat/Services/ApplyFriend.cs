using Newtonsoft.Json;
using System.Text;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public class ApplyFriend
    {
        private readonly HttpClient _client;
        public ApplyFriend()
        {
            _client = new HttpClient();
        }

        public async Task<FriendApplyResponse> GetListApplyFriend()
        {
            FriendApplyResponse res = new FriendApplyResponse();
            try
            {
                string apiUrl = Constant.APPLY_FRIEND_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                string requestBody = "{\"_token\": \"@token@\", \"_agent_id\": \"1\"}";
                requestBody = requestBody.Replace("@token@", Common.token);

                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);


                string responseBody = await response.Content.ReadAsStringAsync();
                res = JsonConvert.DeserializeObject<FriendApplyResponse>(responseBody);

                if (res.err == 0)
                {
                    return res;
                }
            }
            catch (Exception ex)
            {
                return res;
            }
            return res;
        }
    }
}
