namespace GameToonZombie.Data.Algorithm
{
    public class FindNearestZombie
    {
        public static GameState FindNearest(GameState gameState, int range)
        {
            var zombies = gameState.Zombies;
            var basePosition = gameState.Base;
            GameState gameStateInfo = new GameState();

            if (zombies != null && basePosition != null)
            {
                foreach (var zombie in zombies)
                {
                    foreach (var basePos in basePosition)
                    {
                        int rangeToCheck = basePos.IsHead ? range + 3 : range;
                        int inRangeX = Math.Abs(zombie.X - basePos.X);
                        int inRangeY = Math.Abs(zombie.Y - basePos.Y);

                        if (inRangeX <= rangeToCheck && inRangeY <= rangeToCheck)
                        {
                            gameStateInfo.Zombies.Add(zombie);
                            gameStateInfo.Base.Add(basePos);
                            break;
                        }
                    }
                }
            }

            return gameStateInfo;
        }
    }
}
