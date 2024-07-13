using GameToonZombie.Model.Entites.Command;

namespace GameToonZombie.Data.Algorithm
{
    public class Attack
    {
        public static CommandAttack AttackZombie(GameState gameState)
        {
            CommandAttack attack = new CommandAttack {
                BlockId = gameState.Base[0].Id,
                Target =
                {
                    X = gameState.Zombies[0].X,
                    Y = gameState.Zombies[0].Y
                }
            };

            return attack;
        }
    }
}
