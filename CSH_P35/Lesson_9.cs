using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace CSH_P35
{
    class Lesson_9
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            string url = "https://meowfacts.herokuapp.com/";
            var response = await client.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }
    }
}

