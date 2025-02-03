using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeckOfCards
{
    class DeckResponse
    {
        [JsonPropertyName("deck_id")]
        public string Id { get; set; }
        [JsonPropertyName("shuffled")]
        public bool Shuffled { get; set; }
        [JsonPropertyName("remaining")]
        public int Remaining { get; set; }
    }


    class Deck
    {

        public string Id { get; set; }
        public bool Shuffled { get; set; }
        public int Remaining { get; set; }

        private HttpClient httpClient = new HttpClient();

        public Deck(int deckCount = 1)
        {
            string url = "https://deckofcardsapi.com/api/deck/new/shuffle/";
            string parameters = $"?deck_count={deckCount}";
            var deck = DeckRequest(url + parameters);
            this.Id = deck.Id;
            this.Shuffled = deck.Shuffled;
            this.Remaining = deck.Remaining;
        }

        public Deck(string deckId)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/";
            var deck = DeckRequest(url);
            this.Id = deck.Id;
            this.Shuffled = deck.Shuffled;
            this.Remaining = deck.Remaining;
        }

        public void Shuffle()
        {
            string url = $"https://deckofcardsapi.com/api/deck/{this.Id}/shuffle/";
            var deck = DeckRequest(url);
            this.Id = deck.Id;
            this.Shuffled = deck.Shuffled;
            this.Remaining = deck.Remaining;

        }

        private DeckResponse DeckRequest(string url)
        {
            var response = httpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                DeckResponse? deck = JsonSerializer.Deserialize<DeckResponse>(jsonResponse);
                if (deck != null)
                {
                    return deck;
                }
                else throw new Exception($"StatusCode: {response.StatusCode}");
            }
            else throw new Exception($"StatusCode: {response.StatusCode}");
        }
    }

}
