public class GameState
{
    public List<BaseBlock> Base { get; set; }
    public List<EnemyBlock> EnemyBlocks { get; set; }
    public Player Player { get; set; }
    public string RealmName { get; set; }
    public int Turn { get; set; }
    public int TurnEndsInMs { get; set; }
    public List<Zombie> Zombies { get; set; }
}