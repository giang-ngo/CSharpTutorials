using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public class Lesson12
    {
        static readonly string _loginUrl = "https://reqres.in/api/login";
        static readonly string _userInfoUrl = "https://reqres.in/api/users/2"; // Lấy thông tin người dùng

        // Hàm login
        static async Task<string> LoginAsync(string url, LoginData data)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var dataJsonString = JsonConvert.SerializeObject(data);
                    var content = new StringContent(dataJsonString, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        // Hàm lấy thông tin người dùng
        static async Task<string> GetUserInfoAsync(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        static void Main()
        {
            var loginData = new LoginData();
            var jsonDataTask = LoginAsync(_loginUrl, loginData);
            var loginResponse = jsonDataTask.Result;
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                // Parse kết quả đăng nhập
                LoginResult loginResult = JsonConvert.DeserializeObject<LoginResult>(loginResponse);
                Console.WriteLine("==> Token nhận được:");
                Console.WriteLine(loginResult.Token);

                // Gửi yêu cầu để lấy thông tin người dùng
                var userInfoTask = GetUserInfoAsync(_userInfoUrl);
                var userInfoResponse = userInfoTask.Result;

                // Parse kết quả thông tin người dùng
                UserInfoResult userInfoResult = JsonConvert.DeserializeObject<UserInfoResult>(userInfoResponse);
                Console.WriteLine("\n==> Thông tin người dùng:");
                Console.WriteLine(userInfoResult.Data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Response: " + loginResponse);
            }
        }
    }

    class LoginData
    {
        [JsonProperty("email")]
        public string Email { get; set; } = "eve.holt@reqres.in";
        [JsonProperty("password")]
        public string Password { get; set; } = "cityslicka";
    }

    class LoginResult
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    class UserInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nEmail: {Email}\nFirst Name: {FirstName}\nLast Name: {LastName}\nAvatar: {Avatar}";
        }
    }

    class UserInfoResult
    {
        [JsonProperty("data")]
        public UserInfo Data { get; set; }
    }
}
