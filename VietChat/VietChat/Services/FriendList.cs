using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public class FriendList
    {

        private readonly HttpClient _client;
        public FriendList()
        {
            _client = new HttpClient();
        }
        public async Task<FriendListData> GetFriendList()
        {
            string apiUrl = Constant.GET_FRIEND_LIST_API;
            FriendListData friendList = new FriendListData();
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

            string requestBody = "{\"client_id\": \"\", \"_token\": \"@token@\", \"_agent_id\": \"1\"}";
            requestBody = requestBody.Replace("@token@", Common.token);

            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.SendAsync(request);


            string responseBody = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(responseBody);


            if (!jObject["err"].ToString().Equals("0"))
            {
                return friendList;
            }

            JObject jObject1 = (JObject)jObject["data"];

            JObject jObject2 = (JObject)jObject1["data"];

            foreach (var section in jObject2)
            {
                Friend friend = new Friend();

                var zone = section.Key;

                JObject jObject3 = (JObject)jObject2[zone];

                friend.letter = (string)jObject3["letter"];
                friend.index = (int)jObject3["index"];

                JArray jarr = jObject3["data"].ToObject<JArray>();

                for (int i = 0; i < jarr.Count; i++)
                {
                    JObject obj = (JObject)jarr[i];

                    FriendInfo friendInfo = new FriendInfo();
                    friendInfo.user_id = (int)obj["user_id"];
                    friendInfo.photo = (string)obj["photo"];
                    friendInfo.name = (string)obj["name"];

                    friend.data = friendInfo;
                    friendList.data.Add(friend);
                }
            }
            return friendList;
        }

        public async Task<bool> AddFriend(string content, string user_id)
        {
            try
            {
                string apiUrl = Constant.ADD_FRIEND_API;
                FriendListData friendList = new FriendListData();
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                string requestBody = "{\"content\": \"@content@\" , \"user_id\": \"@user_id@\" , \"_token\": \"@token@\", \"is_type\": \"0\", \"_agent_id\": \"1\"}";
                requestBody = requestBody.Replace("@content@", content);
                requestBody = requestBody.Replace("@user_id@", user_id);
                requestBody = requestBody.Replace("@token@", Common.token);

                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);

                string responseBody = await response.Content.ReadAsStringAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
                    
        }
    }
}
