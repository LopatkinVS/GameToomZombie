public class Player
{
    public int Gold { get; set; }
    public int Points { get; set; }
    public string Name { get; set; }
    public int ZombieKills { get; set; }
    public int EnemyBlockKills { get; set; }
    public DateTime? GameEndedAt { get; set; }
}