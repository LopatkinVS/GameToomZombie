using GameToonZombie.Model.Entites.Command;

namespace GameToonZombie.Data.Algorithm
{
    public class BuildInThirstMove
    {
        public static List<CommandBuild> BuildSquare(GameState gameState)
        {
            int minXPostition = int.MaxValue;
            int minYPostition = int.MaxValue;
            List<CommandBuild> commandBuilds = new List<CommandBuild>();
            List<BaseBlock> blocks = gameState.Base;

            foreach(var block in blocks)
            {
                if (block.X < minXPostition)
                {
                    minXPostition = block.X;
                }
                if(block.Y < minYPostition)
                {
                    minYPostition = block.Y;
                }
            }

            CommandBuild build1 = new CommandBuild { 
                X = minXPostition - 1,
                Y = minYPostition,
            };
            CommandBuild build2 = new CommandBuild { 
                X = minXPostition - 1,
                Y = minYPostition + 1,
            };
            CommandBuild build3 = new CommandBuild { 
                X = minXPostition,
                Y = minYPostition -1,
            };
            CommandBuild build4 = new CommandBuild { 
                X = minXPostition + 1,
                Y = minYPostition - 1,
            };
            CommandBuild build5 = new CommandBuild { 
                X = minXPostition + 2,
                Y = minYPostition,
            };
            CommandBuild build6 = new CommandBuild { 
                X = minXPostition + 2,
                Y = minYPostition + 1,
            };
            CommandBuild build7 = new CommandBuild { 
                X = minXPostition + 1,
                Y = minYPostition + 2,
            };
            CommandBuild build8 = new CommandBuild { 
                X = minXPostition,
                Y = minYPostition + 2,
            };
            CommandBuild build9 = new CommandBuild { 
                X = minXPostition + 3,
                Y = minYPostition + 1,
            };
            CommandBuild build10 = new CommandBuild { 
                X = minXPostition - 2,
                Y = minYPostition,
            };

            commandBuilds.Add(build1);
            commandBuilds.Add(build2);
            commandBuilds.Add(build3);
            commandBuilds.Add(build4);
            commandBuilds.Add(build5);
            commandBuilds.Add(build6);
            commandBuilds.Add(build7);
            commandBuilds.Add(build8);
            commandBuilds.Add(build9);
            commandBuilds.Add(build10);

            return commandBuilds;
        }
    }
}
