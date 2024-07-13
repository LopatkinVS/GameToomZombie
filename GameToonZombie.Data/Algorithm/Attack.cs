using GameToonZombie.Model.Entites.Command;
using System.Collections.Generic;

namespace GameToonZombie.Data.Algorithm
{
    public class Attack
    {
        public static List<CommandAttack> AttackZombie(GameState gameState)
        {
            List<CommandAttack> listAttack = new List<CommandAttack>();

            if (gameState?.Base != null && gameState.Base.Count > 0 &&
                gameState?.Zombies != null && gameState.Zombies.Count > 0)
            {
                CommandAttack attack = new CommandAttack
                {
                    BlockId = gameState.Base[0].Id,
                    Target = new CommandTarget
                    {
                        X = gameState.Zombies[0].X,
                        Y = gameState.Zombies[0].Y
                    }
                };

                listAttack.Add(attack);
            }

            return listAttack;
        }
    }
}
