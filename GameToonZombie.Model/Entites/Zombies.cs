using GameToonZombie.Model.Abstract;

namespace GameToonZombie.Model.Entites
{
    public class Zombies : IEntityBase
    {
        public Guid GuidId { get ; set ; }
        public int Attack { get; set ; }
        public string Direction { get; set ; }
        public int Health { get; set ; }
        public int Speed { get; set ; }
        public string Type { get; set ; }
        public int WaitTurns { get; set ; } 
        public int XPosition { get; set ; }
        public int YPosition { get; set ; }
    }
}
