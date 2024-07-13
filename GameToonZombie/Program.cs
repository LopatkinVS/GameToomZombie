using GameToonZombie.Data.Algorithm;
using GameToonZombie.Model.Entites.Command;
using System;
using System.Net.Http.Headers;

class Program
{
    static async Task Main(string[] args)
    {
        var getRequest = new GetRequest();
        var postRequest = new PostRequest();

        try
        {
            var gameState = await getRequest.GetGameStateAsync();

            if (gameState != null)
            {
                GameState gameStateInfo = FindNearestZombie.FindNearest(gameState, CountRangeAttack.CountRange(gameState));

                if (gameStateInfo != null)
                {
                    var commandData = new CommandData
                    {
                        Attack = Attack.AttackZombie(gameStateInfo)
                    };

                    await postRequest.SendPostRequestBuildAndAtackAsync(commandData);
                }

                if(gameState.Turn == 1)
                {
                    // алгоритм постройки стен
                }

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
