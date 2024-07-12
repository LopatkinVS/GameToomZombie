using GameToonZombie.BI.Interfaces;
using GameToonZombie.BI.Helper;
using GameToonZombie.Model.Entites;

namespace GameToonZombie.BI.Services
{
    public class BaseService : IBaseService
    {
        public string Attack(Guid blockId, int XPosition, int YPosition, bool InRange)
        {
            if (!InRange)
                return null;

            EnemyPosition enemyPosition = new EnemyPosition
            {
                BasePos = blockId,
                XPos = XPosition,
                YPos = YPosition
            };

            return BaseHelper.GetAttack(enemyPosition);
        }

        public double CountRange(int XPos1, int XPos2, int YPos1, int YPos2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(XPos1 - XPos2), 2) + Math.Pow(Math.Abs(YPos1 - YPos2), 2));
        }

        public string MoveBase(int XPos, int YPos)
        {
            BasePoz basePoz = new BasePoz
            {
                XPos = XPos,
                YPos = YPos
            };

            return BaseHelper.GetBasePos(basePoz);
        }

        public string PlaceAWall(int XPos, int YPos)
        {
            WallPos wallpos = new WallPos
            {
                XPos = XPos,
                YPos = YPos
            };

            return BaseHelper.GetWallPos(wallpos);
        }
    }
}
