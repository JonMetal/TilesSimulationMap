using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry
{
    public class ChemicalTile
    {
        public List<SubstanceAmount> SubstanceAmounts { get; private set; } = [];

        public decimal PH { get; private set; }

        public decimal Conductivity { get; private set; }

        // Смачиваемость
        public decimal Wettability { get; private set; }
    }
}
