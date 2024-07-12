using GameToonZombie.Model.Abstract;

namespace GameToonZombie.Model.Entites
{
    public class EnemyBlocks
    {
        public int Attack { get; set; }
        public int Health { get; set; }
        public bool IsHead { get; set; }
        public List<int> LastAtack { get; set; }
        public string Name { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
    }
}
