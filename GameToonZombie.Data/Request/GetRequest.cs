using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class GetRequest
{
    private readonly string url = "https://games-test.datsteam.dev/play/zombidef/command";
    private readonly string apiKey = "66904631b1f7a66904631b1f7d";
    private readonly string xAuthToken = "66904631b1f7a66904631b1f7d";

    public async Task<GameState> GetGameStateAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.Add("ApiKeyAuth", apiKey);
                client.DefaultRequestHeaders.Add("X-Auth-Token", xAuthToken);

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                GameState gameState = JsonConvert.DeserializeObject<GameState>(responseBody);
                return gameState;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Запрос завершился ошибкой: {e.Message}");
                return null;
            }
        }
    }
}
