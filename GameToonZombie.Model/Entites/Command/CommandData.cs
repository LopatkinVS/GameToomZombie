using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToonZombie.Model.Entites.Command
{
    public class CommandData
    {
        public List<CommandAttack> Attack { get; set; }
        public List<CommandBuild> Build { get; set; }
        public CommandMoveBase MoveBase { get; set; }
    }
}
