using GameToonZombie.Data.Algorithm;
using GameToonZombie.Model.Entites.Command;
using System;
using System.Net;
using System.Net.Http.Headers;

class Program
{
    static async Task Main(string[] args)
    {
        var getRequest = new GetRequest();
        var postRequest = new PostRequest();
        while (true)
        {
            try
            {
                var gameState = await getRequest.GetGameStateAsync();
                if (gameState != null)
                {
                    if (gameState.Base != null)
                    {
                        GameState gameStateInfo = FindNearestZombie.FindNearest(gameState, 5);

                        if (gameStateInfo.Zombies != null)
                        {
                            var commandData = new CommandData
                            {
                                Attack = Attack.AttackZombie(gameStateInfo)
                            };

                            if (commandData != null)
                                await postRequest.SendPostRequestBuildAndAtackAsync(commandData);

                        }

                        if (gameState.Turn == 1)
                        {
                            List<CommandBuild> commandBuilds = BuildInThirstMove.BuildSquare(gameState);
                            var commandData = new CommandData();
                            commandData.Build = commandBuilds;
                            await postRequest.SendPostRequestBuildAndAtackAsync(commandData);
                        }

                        if (gameState.Player.Gold >= 10)
                        {
                            List<CommandBuild> commandBuilds = BuildInThirstMove.BuildSquare(gameState);
                            var commandData = new CommandData();
                            commandData.Build = commandBuilds;
                            await postRequest.SendPostRequestBuildAndAtackAsync(commandData);
                        }

                        Console.WriteLine($"Состояние игры: {gameState}");
                    }
                    else
                    {
                        Console.WriteLine("Не удалось получить состояние игры.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при получении состояния игры: {ex.Message}");
            }

            Thread.Sleep(2000);
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
