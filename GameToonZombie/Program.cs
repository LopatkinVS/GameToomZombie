using GameToonZombie.Model.Entites.Command;
using System;
using System.Net.Http.Headers;

class Program
{
    static async Task Main(string[] args)
    {
        var getRequest = new GetRequest();

        try
        {
            var gameState = await getRequest.GetGameStateAsync();

            if (gameState != null)
            {
                Console.WriteLine($"Состояние игры: {gameState}");
            }
            else
            {
                Console.WriteLine("Не удалось получить состояние игры.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при получении состояния игры: {ex.Message}");
        }


        var postRequest = new PostRequest();

        try
        {
            var commandData = new CommandData
            {

            };

            await postRequest.SendPostRequestBuildAndAtackAsync(commandData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при отправке POST-запроса: {ex.Message}");
        }
    }
}
