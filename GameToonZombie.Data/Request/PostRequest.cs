using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using GameToonZombie.Model.Entites.Command;

public class PostRequest
{
    private readonly string url = "https://games-test.datsteam.dev/play/zombidef/command";
    private readonly string apiKey = "66904631b1f7a66904631b1f7d";
    private readonly string xAuthToken = "66904631b1f7a66904631b1f7d";

    public async Task SendPostRequestBuildAndAtackAsync(CommandData data)
    {
        data = new CommandData
        {
            Attack = new List<CommandAttack>
            {
                new CommandAttack
                {
                    BlockId = "f47ac10b-58cc-0372-8562-0e02b2c3d479",
                    Target = new CommandTarget { X = 1, Y = 1 }
                }
            },
            Build = new List<CommandBuild>
            {
                new CommandBuild { X = 1, Y = 1 }
            },
            MoveBase = new CommandMoveBase { X = 1, Y = 1 }
        };

        string jsonData = JsonConvert.SerializeObject(data);

        using (HttpClient client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.Add("ApiKeyAuth", apiKey);
                client.DefaultRequestHeaders.Add("X-Auth-Token", xAuthToken);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
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
