using Newtonsoft.Json.Linq;
using System.Text;
using VietChat.Constants;

namespace VietChat.Services
{
	public class Register
    {
        private readonly HttpClient _client;
        public Register() 
        {
            _client = new HttpClient();
        }

		public async Task Registering(string username, string pass) 
		{
            try
            {
                string apiUrl = Constant.REGISTER_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                // Add request body if needed
                string requestBody = "{\"username\": \"@username@\", \"password\": \"@password@\", \"client_id\": \"\", \"_token\": \"\", \"_agent_id\": \"1\", \"mobileCode\": \"0\", \"type\": \"REGISTER\"}";
                requestBody = requestBody.Replace("@username@", username);
                requestBody = requestBody.Replace("@password@", pass);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject jObject = JObject.Parse(responseBody);
                    Common.error_flag = (int)jObject["err"];
                    Common.msg = (string)jObject["msg"];
                    MessageBox.Show(Common.msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed with status code {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private string ImageToBase64(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        public async Task uploadPhoto(string path)
        {
            try
            {
                string apiUrl = Constant.UPLOAD_PHOTO_API;
                string contents = ImageToBase64(path);

                await using var stream = System.IO.File.OpenRead(path);
                using var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
                using var content = new MultipartFormDataContent
                {
                    { new StreamContent(stream), "file", "user.png" },
                    { new StringContent(Common.token), "_token" },
                };

                request.Content = content;

                HttpResponseMessage response = await _client.SendAsync(request);

                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task setProfile(string file, string nickname)
        {
            try
            {
                string apiUrl = Constant.SET_PROFILE_API;
                var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);

                // Add request body if needed
                string requestBody = "{\"file\": \"@file@\", \"_token\": \"@token@\", \"nickname\": \"@nickname@\", \"_agent_id\": \"1\"}";
                requestBody = requestBody.Replace("@file@", file);
                requestBody = requestBody.Replace("@token@", Common.token);
                requestBody = requestBody.Replace("@nickname@", nickname);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
