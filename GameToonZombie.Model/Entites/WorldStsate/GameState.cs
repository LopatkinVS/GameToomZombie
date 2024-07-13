public class GameState
{
    public string RealmName { get; set; }
    public Player Player { get; set; }
    public List<Zombie> Zombies { get; set; } = new List<Zombie>();
    public List<BaseBlock> Base { get; set; } = new List<BaseBlock>();
    public List<EnemyBlock> EnemyBlocks { get; set; }
    public int TurnEndsInMs { get; set; }
    public int Turn { get; set; }
}