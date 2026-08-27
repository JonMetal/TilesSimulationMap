using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualPrototype.GameWorld.Tiles.Structure;

namespace VisualPrototype.GameWorld.Tiles
{
    public class TileDefinition
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public StaticTerrain StaticTerrain { get; init; }
    }
}
