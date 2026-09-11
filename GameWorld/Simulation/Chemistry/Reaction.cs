using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry
{
    public class Reaction
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Equation { get; init; } = "";

        public Dictionary<Compound, int> Reagents { get; private set; } = [];
        public Dictionary<Compound, int> Products { get; private set; } = [];


    }
}
