using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public class ChatList
    {
        private readonly HttpClient _client;
        public ChatList()
        {
            _client = new HttpClient();
        }

        public async Task getChatList()
        {
            try
            {
                string apiUrl = Constant.CHATLIST_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                // Add request body if needed
                // string requestBody = "{\"username\": \"@username@\", \"password\": \"@password@\", \"client_id\": \"\", \"_token\": \"\", \"_agent_id\": \"1\"}";
                //  requestBody = requestBody.Replace("@username@", username);
                string requestBody = "{\"client_id\": \"\", \"_token\": \"@token@\", \"_agent_id\": \"1\"}";
                requestBody = requestBody.Replace("@token@", Common.token);

                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);


                string responseBody = await response.Content.ReadAsStringAsync();
                Common.chatList = JsonConvert.DeserializeObject<ChatDataResponse>(responseBody);


                JObject jObject = JObject.Parse(responseBody);

                if (!jObject["err"].ToString().Equals("0"))
                {
                    return;
                }
                else
                {
                    JArray jarr = jObject["data"].ToObject<JArray>();

                    for (int i = 0; i < jarr.Count; i++)
                    {
                        JObject obj = (JObject)jarr[i]; //nhận obj thứ i
                        Common.list_id = obj["list_id"].ToString();
                        Common.chat_id = obj["chat_id"].ToString();
                        Common.last_msg = obj["last_msg"].ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                //  MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public async void getTextMsg(string msg)
        {
            try
            {
                string apiUrl = Constant.GET_TEXTMSG_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                // Add request body if needed
                string content = "{\"text\": \"@msg@\"}";
                content = content.Replace("@msg@", msg.Trim());
                var formContent = new FormUrlEncodedContent(new[]
                                  {
                                   new KeyValuePair<string, string>("_token", Common.token),
                                   new KeyValuePair<string, string>("_agent_id", "1"),
                                   new KeyValuePair<string, string>("list_id", Common.list_id),
                                   new KeyValuePair<string, string>("content_type", "0"),
                                  new KeyValuePair<string, string>("content", content)
                                    });

                HttpResponseMessage response = await _client.PostAsync(apiUrl, formContent);

                string responseBody = await response.Content.ReadAsStringAsync();

                JObject jObject = JObject.Parse(responseBody);

                if (!jObject["err"].ToString().Equals("0"))
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public async Task<ChatDataRespone> getChatData()
        {
            ChatDataRespone chatDataRespone = new ChatDataRespone();
            try
            {
                string apiUrl = Constant.CHATDATA_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                string requestBody = "{\"list_id\": \"@list_id@\", \"is_up\": \"1\", \"is_action_data\": \"1\", \"_agent_id\": \"1\", \"_token\": \"@token@\", \"time\": \"0\"}";
                requestBody = requestBody.Replace("@list_id@", Common.list_id);
                requestBody = requestBody.Replace("@token@", Common.token);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);


                string responseBody = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(responseBody))
                {
                    return chatDataRespone;
                }

                chatDataRespone = JsonConvert.DeserializeObject<ChatDataRespone>(responseBody);
            }
            catch (Exception ex)
            {
                return null;
            }

            return chatDataRespone;
        }

        public async void getListFriend()
        {
            try
            {
                string apiUrl = Constant.GET_FRIEND_LIST_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                string requestBody = "{\"client_id\": \"\", \"_token\": \"@token@\", \"_agent_id\": \"1\"}";
                requestBody = requestBody.Replace("@token@", Common.token);

                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);


                string responseBody = await response.Content.ReadAsStringAsync();

                JObject jObject = JObject.Parse(responseBody);

                if (!jObject["err"].ToString().Equals("0"))
                {
                    return;
                }

                JObject jObject1 = (JObject)jObject["data"];

                JObject jObject2 = (JObject)jObject1["data"];

                foreach (var section in jObject2)
                {
                    var zone = section.Key;

                    JObject jObject3 = (JObject)jObject2[zone];

                    JArray jarr = jObject3["data"].ToObject<JArray>();

                    for (int i = 0; i < jarr.Count; i++)
                    {
                        JObject obj = (JObject)jarr[i]; //nhận obj thứ i
                        //Common.name_friend = obj["name"].ToString();
                        Common.user_id_friend = obj["user_id"].ToString();
                        //Common.photo = obj["photo"].ToString();
                        Common.job_friend.Add(new JProperty(Common.user_id_friend, obj));
                    }
                }

            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
