using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation
{
    public enum SubstanceType : byte
    {
        Solid = 1,
        Liquid = 2,
        Gas = 3
    }

    public enum ElementCategory : byte
    {
        // Металлы
        AlkaliMetal = 1,          // Li, Na, K...
        AlkalineEarthMetal = 2,   // Be, Mg, Ca...
        TransitionMetal = 3,      // Fe, Cu, Zn...
        PostTransitionMetal = 4,  // Al, Ga, Sn...
        Lanthanide = 5,           // La-Lu
        Actinide = 6,             // Ac-Lr

        // Металлоиды
        Metalloid = 7,            // B, Si, Ge, As...

        // Неметаллы
        Nonmetal = 8,             // C, N, O, P, S...
        Halogen = 9,              // F, Cl, Br, I...
        NobleGas = 10,            // He, Ne, Ar...

        // Особые
        Hydrogen = 11             // H (отдельно)
    }
}
