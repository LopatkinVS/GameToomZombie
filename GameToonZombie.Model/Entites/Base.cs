using GameToonZombie.Model.Abstract;

namespace GameToonZombie.Model.Entites
{
    public class Base : IEntityBase
    {
        public int Attack { get; set; }
        public int Health { get; set; }
        public Guid GuidId { get; set; }
        public bool IsHead { get; set; }
        public List<int> LastAtack { get; set; }
        public int Range { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
    }
}
