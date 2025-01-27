using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace CSH_P35
{
    class MeowFactsData
    {
        public List<string> data { get; set; }
    }

    //class Lesson_9
    //{
    //    public static async Task<MeowFactsData?> GetMeowFacts(int count=1, string lang="eng")
    //    {
    //        var client = new HttpClient();

    //        string url = "https://meowfacts.herokuapp.com/";
    //        // int count = 3; string lang = "ukr";
    //        string parameters = $"?count={count}&lang={lang}";

    //        var response = await client.GetAsync(url + parameters);

    //        if (response.IsSuccessStatusCode)
    //        {
    //            var jsonResponse = await response.Content.ReadAsStringAsync();
    //            return JsonSerializer.Deserialize<MeowFactsData>(jsonResponse);
    //        }
    //        return null;
    //    }
    //    public static async Task Main(string[] args)
    //    {
    //        Console.OutputEncoding = UTF8Encoding.UTF8;
    //        Console.InputEncoding = UTF8Encoding.UTF8;

    //        var facts = await GetMeowFacts(3, "ukr");
    //        if (facts == null) { Console.WriteLine(" Не вдалося отримати факти."); }
    //        else
    //        {
    //            foreach (var fact in facts.data) { Console.WriteLine(fact + "\n\n"); }
    //        }
    //    }
    //}
}

