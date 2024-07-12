using GameToonZombie.Model.Entites;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace GameToonZombie.BI.Helper
{
    public class BaseHelper
    {
        public static string GetAttack(EnemyPosition enemyPosition)
        {
            var PosToAttack = new EnemyPosition
            {
                BasePos = enemyPosition.BasePos,
                XPos = enemyPosition.XPos,
                YPos = enemyPosition.YPos
            };

            string JsonAtackPos = JsonSerializer.Serialize(PosToAttack);
           
            return JsonAtackPos;
        }

        public static string GetWallPos(WallPos wallPos)
        {
            var PosOfTheWall = new WallPos
            {
                XPos = wallPos.XPos,
                YPos = wallPos.YPos,
            };

            string JsonWallPos = JsonSerializer.Serialize(PosOfTheWall);
            
            return JsonWallPos;
        }

        public static string GetBasePos(BasePoz basePoz)
        {
            var basePos = new BasePoz
            {
                XPos = basePoz.XPos,
                YPos = basePoz.YPos,
            };

            string JsonBasePos = JsonSerializer.Serialize(basePos);

            return JsonBasePos;
        }
    }
}
