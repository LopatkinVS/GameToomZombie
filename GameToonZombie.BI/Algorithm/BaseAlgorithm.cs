using GameToonZombie.BI.Helper;
using GameToonZombie.Model.Entites;

namespace GameToonZombie.BI.Algorithm
{
    public class BaseAlgorithm
    {
        public string PlaceWall(int posX, int posY)
        {
            WallPos newWallPos = new WallPos
            {
                XPos = posX,
                YPos = posY
            };

            return BaseHelper.GetWallPos(newWallPos);
        }
    }
}
