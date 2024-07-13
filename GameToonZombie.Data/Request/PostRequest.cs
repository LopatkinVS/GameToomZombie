using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using GameToonZombie.Model.Entites.Command;

public class PostRequest
{
    private readonly string _url = "https://games-test.datsteam.dev/play/zombidef/command";
    private readonly string _apiKey = "66904631b1f7a66904631b1f7d";
    private readonly string _xAuthToken = "66904631b1f7a66904631b1f7d";

    public async Task SendPostRequestBuildAndAtackAsync(CommandData data)
    {
        string jsonData = JsonConvert.SerializeObject(data);

        using (HttpClient client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.Add("ApiKeyAuth", _apiKey);
                client.DefaultRequestHeaders.Add("X-Auth-Token", _xAuthToken);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(_url, content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Запрос завершился ошибкой: {e.Message}");
            }
        }
    }
}
