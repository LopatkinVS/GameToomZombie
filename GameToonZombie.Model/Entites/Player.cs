using GameToonZombie.Model.Abstract;

namespace GameToonZombie.Model.Entites
{
    public class Player 
    {
        public int EnemyBlockKills { get; set; }
        public DateTime GameEndAt { get; set; }
        public int Goald {  get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int ZombieKills { get; set; }
    }
}
