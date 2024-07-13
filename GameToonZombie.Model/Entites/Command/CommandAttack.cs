using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToonZombie.Model.Entites.Command
{
    public class CommandAttack
    {
        public string BlockId { get; set; }
        public CommandTarget Target { get; set; }
    }
}
