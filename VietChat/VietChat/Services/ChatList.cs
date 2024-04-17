﻿using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Windows.Forms;
using VietChat.Constants;

namespace VietChat.Services
{
    public class ChatList
    {
        private readonly HttpClient _client;
        public ChatList()
        {
            _client = new HttpClient();
        }

        public async void getChatList()
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

                JObject jObject = JObject.Parse(responseBody);

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                JObject jObject3 = (JObject)jObject2["19"];

                JArray jarr = jObject3["data"].ToObject<JArray>();

                for (int i = 0; i < jarr.Count; i++)
                {
                    JObject obj = (JObject)jarr[i]; //nhận obj thứ i
                    Common.name_friend = obj["name"].ToString();
                    Common.user_id_friend = obj["user_id"].ToString();
                    Common.photo = obj["photo"].ToString();
                }

            }
            catch (HttpRequestException ex)
            {
                return;
            }
        }
    }
}
