using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualPrototype.GameWorld.Simulation;

namespace VisualPrototype.GameWorld.Tiles.Structure
{
    public class DynamicTile
    {
        public decimal MaxVolume { get; set; } = 0.0m;

        public decimal CurrentPressure { get; set; } = 0.0m;

        public decimal Temperature { get; set; } = 0.0m;

        private List<Substance> _substances = [];
    }
}
