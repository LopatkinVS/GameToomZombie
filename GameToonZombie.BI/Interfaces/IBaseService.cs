namespace GameToonZombie.BI.Interfaces
{
    public interface IBaseService
    {
        double CountRange(int XPos1, int XPos2, int YPos1, int YPos2);
        string Attack(Guid blockId, int XPosition, int YPosition, bool InRange);
        string PlaceAWall(int XPos, int YPos);
        string MoveBase(int XPos, int YPos);
    }
}
