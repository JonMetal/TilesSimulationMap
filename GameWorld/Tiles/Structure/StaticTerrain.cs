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
    }
}
