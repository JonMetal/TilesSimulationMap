using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualPrototype.GameWorld.Tiles.Models;

namespace VisualPrototype.GameWorld.Tiles.Structure
{
    public class StaticTerrain
    {
        public int TerrainTypeId { get; init; }
        public TerrainType? TerrainType { get; init; }

        public decimal MaxVolume { get; set; } = 0.0m;
        public decimal SideLength = 1.0m;
    }
}
