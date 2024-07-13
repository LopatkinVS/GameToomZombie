using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToonZombie.Model.Entites.Command
{
    public class CommandData
    {
        public CommandAttack Attack { get; set; }
        public CommandBuild Build { get; set; }
        public CommandMoveBase MoveBase { get; set; }
    }
}
