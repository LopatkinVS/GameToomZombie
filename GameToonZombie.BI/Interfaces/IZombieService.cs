using GameToonZombie.Model.Entites;

namespace GameToonZombie.BI.Interfaces
{
    public interface IZombieService
    {
        List<List<string>> GetEveryZombiePositionAndType(List<int> zombies);
        
    }
}
