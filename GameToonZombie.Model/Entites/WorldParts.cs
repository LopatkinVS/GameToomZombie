namespace GameToonZombie.Model.Entites
{
    public class WorldParts
    {
        public Base Base { get; set; }
        public EnemyBlocks EnemyBlocks { get; set; }
        public Player Player { get; set; }
        public string RealName { get; set; }
        public int Turn {  get; set; }
        public int TurnEndsInMs { get; set; }
        public Zombies Zombies { get; set; }
    }
}
