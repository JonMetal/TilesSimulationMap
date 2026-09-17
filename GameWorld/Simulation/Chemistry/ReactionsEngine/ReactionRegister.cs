using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry.ReactionsEngine
{
    public class ReactionRegister
    {
        public List<Reaction> Reactions { get; set;  }

        public List<Reaction> ReadReactionFromJson(string json)
        {
            throw new NotImplementedException();
        }
    }
}
