namespace GameToonZombie.Data.Algorithm
{
    public class FindNearestZombie
    {
        public static GameState FindNearest(GameState gameState, int range)
        {
            var zombies = gameState.Zombies;
            var basePosition = gameState.Base;
            GameState gameStateInfo = new GameState();
            Zombie inRangeZombie = new Zombie();
            BaseBlock baseBlockInRange = new BaseBlock();


            foreach ( var zombie in zombies )
            {
                foreach ( var basePos  in basePosition )
                {
                    int inRangeX = Math.Abs(zombie.X - basePos.X);
                    int inRangeY = Math.Abs(zombie.X - basePos.X);
                    if (inRangeX <= range && inRangeY <= range)
                    {
                        gameStateInfo.Zombies.Add(zombie);
                        gameStateInfo.Base.Add(basePos);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return gameStateInfo;
        }
    }
}
