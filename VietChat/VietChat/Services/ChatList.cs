using Newtonsoft.Json.Linq;
using System.Text;
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
                string apiUrl = Constant.ONLINE_LIST_API;
                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);

                // Add request body if needed
                string requestBody = "{\"username\": \"@username@\", \"password\": \"@password@\", \"client_id\": \"\", \"_token\": \"\", \"_agent_id\": \"1\", \"mobileCode\": \"0\", \"type\": \"REGISTER\"}";
                requestBody = requestBody.Replace("@_token@", Common.token);
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
	}
}
