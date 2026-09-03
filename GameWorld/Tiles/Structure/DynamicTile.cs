using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualPrototype.GameWorld.Simulation;
using VisualPrototype.GameWorld.Tiles.Structure.BuildingStructure;

namespace VisualPrototype.GameWorld.Tiles.Structure
{
    public class DynamicTile
    {
        public decimal CurrentPressure { get; set; } = 0.0m;

        public decimal Temperature { get; set; } = 0.0m;

        public bool IsHaveRoof = true;

        private List<Substance> _substances = [];

        private List<Building> _buildings = [];
    }
}
