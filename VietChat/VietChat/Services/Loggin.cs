using Newtonsoft.Json.Linq;
using System.Text;
using VietChat.Constants;
using VietChat.Model;

namespace VietChat.Services
{
    public partial class Logging
    {
        private readonly HttpClient _client;
        public Logging()
        {
            _client = new HttpClient();
        }

        public async Task Signing(string username, string pass)
        {
            try
            {
                string apiUrl = Constant.LOGGIN_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                // Add request body if needed
                string requestBody = "{\"username\": \"@username@\", \"password\": \"@password@\", \"client_id\": \"\", \"_token\": \"\", \"_agent_id\": \"1\"}"; // Example JSON request body
                requestBody = requestBody.Replace("@username@", username);
                requestBody = requestBody.Replace("@password@", pass);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                Common.user = username;
                Common.pass = pass;

                HttpResponseMessage response = await _client.SendAsync(request);

                string responseBody = await response.Content.ReadAsStringAsync();

                JObject jObject = JObject.Parse(responseBody);

                Common.error_flag = (int)jObject["err"];
                Common.msg = (string)jObject["msg"];

                if (Common.error_flag > 0)
                {
                    MessageBox.Show(Common.msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    JObject jObject2 = JObject.Parse(jObject["data"].ToString());
                    Common.token = (string)jObject2["token"];

                    BaseInfo baseInfo = new BaseInfo();
                    baseInfo.GetBase();

                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
