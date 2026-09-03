using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Tiles
{
    public enum TileFlags : byte
    {
        Passable = 1,
        Solid = 2,
        FluidContainer = 4,  // Пол, решётка, сосуд
        GasPermeable = 8     // Пропускает газ (решётка, открытая дверь)
    }
}
