namespace GameToonZombie.Data.Algorithm
{
    public class CountRangeAttack
    {
        public static int CountRange(GameState gameState)
        {
            var baseBlock = gameState.Base;

            return (int)Math.Sqrt(Math.Pow(Math.Abs(baseBlock[0].X - baseBlock[baseBlock.Count - 1].X), 2) + Math.Pow(Math.Abs(baseBlock[0].Y - baseBlock[baseBlock.Count - 1].Y), 2));
        }
    }
}
