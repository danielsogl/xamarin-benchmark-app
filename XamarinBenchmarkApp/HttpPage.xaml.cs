using System.Net.Http;

using System.Diagnostics;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Text;

namespace XamarinBenchmarkApp
{

    public class Comment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }



    public partial class HttpPage : ContentPage
    {

        HttpClient client;
        public string endpoint = "http://jsonplaceholder.typicode.com";
        Stopwatch stopwatch = new Stopwatch();

        public HttpPage()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        async void GetComments(object sender, System.EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 1; i < 101; i++)
            {
                HttpResponseMessage response = null;
                response = await client.GetAsync(endpoint + "/comments/" + i);

                if (response.IsSuccessStatusCode)
                {
                    await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("Get Complete");
                }
            }

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        async void PostComments(object sender, System.EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 1; i < 101; i++)
            {
                HttpResponseMessage response = null;
                var comment = new Comment();
                comment.id = i;
                comment.name = "Lorem Ipsum";
                comment.email = "test@mail.com";
                comment.body = "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium";
                var json = JsonConvert.SerializeObject(comment);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync(endpoint + "/comments/", content);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Post Complete");
                }
            }

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        async void PutComments(object sender, System.EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 1; i < 101; i++)
            {
                HttpResponseMessage response = null;
                var comment = new Comment();
                comment.id = i;
                comment.name = "Lorem Ipsum";
                comment.email = "test@mail.com";
                comment.body = "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium";
                var json = JsonConvert.SerializeObject(comment);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync(endpoint + "/comments/" + i, content);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Put Complete");
                }
            }

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.Milliseconds);
        }

        async void DeleteComments(object sender, System.EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 1; i < 101; i++)
            {
                HttpResponseMessage response = null;
                response = await client.DeleteAsync(endpoint + "/comments/" + i);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Delete Complete");
                }
            }

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.Milliseconds);
        }
    }
}
