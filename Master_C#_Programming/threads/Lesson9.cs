using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    public class Lesson9
    {
        static readonly string _url = "https://jsonplaceholder.typicode.com/comments"; 
        private static HttpClient _httpClient = new HttpClient();

        public static async Task<string> getJsonData(string url)
        {
            try
            {
                //var response = await _httpClient.GetAsync(url);
                //response.EnsureSuccessStatusCode();
                //return await response.Content.ReadAsStringAsync();
                return await _httpClient.GetStringAsync(url);
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
        }

        static void Main()
        {
            var jsonDataTask = getJsonData(_url);
            var jsonString = jsonDataTask.Result;
            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(jsonString);
            ShowComments(comments);
        }

        private static void ShowComments(List<Comment> comments)
        {
            foreach (Comment comment in comments)
            {
                Console.WriteLine(comment);
            }
        }
    }

    class Comment
    {
        [JsonProperty("postId")]
        public int PostId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }

        public Comment()
        {
        }

        public Comment(int postId, int id, string name, string email, string body)
        {
            PostId = postId;
            Id = id;
            Name = name;
            Email = email;
            Body = body;
        }

        public override string ToString()
        {
            return $"[PostId: {PostId}, Id: {Id}, Name: {Name}, Email: {Email}, Body: {Body}]";
        }
    }
}
