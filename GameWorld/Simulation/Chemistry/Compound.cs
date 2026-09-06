using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry
{
    public class Compound
    {
        public readonly string Formula = "";
        public readonly string Name = "";
        public readonly bool IsElement;

        public Dictionary<Element, byte> Composition = [];

        public readonly decimal MolarMass;

        public readonly short MeltingPoint;
        public readonly short BoilingPoint;
        public readonly short Density;
        public readonly Phase StandardPhase;

        public decimal Conductivity = 0.0m;

        public Compound(string formula, string name, bool isElement, Dictionary<Element, byte> composition, 
            short meltingPoint, short boilingPoint, short density, 
            Phase standardPhase, decimal conductivity)
        {
            Formula = formula;
            Name = name;
            IsElement = isElement;
            Composition = composition;
            MeltingPoint = meltingPoint;
            BoilingPoint = boilingPoint;
            Density = density;
            StandardPhase = standardPhase;
            Conductivity = conductivity;
        }
    }
}
