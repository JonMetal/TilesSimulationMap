using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry
{
    public struct Element
    {
        public readonly byte AtomicNumber;
        public readonly string Symbol = "";
        public readonly string Name = "";
        public readonly decimal AtomicMass;
        public readonly ElementCategory ElementCategory;
        public readonly short MeltingPoint;
        public readonly short BoilingPoint;
        public readonly decimal Density;

        public readonly byte DefaultValence;
        public readonly sbyte[] OxidationStates;

        public Element(byte atomicNumber, string symbol, string name, 
            decimal atomicMass, ElementCategory elementCategory, 
            short meltingPoint, short boilingPoint, decimal density, byte defaultValence, sbyte[] oxidationStates)
        {
            AtomicNumber = atomicNumber;
            Symbol = symbol;
            Name = name;
            AtomicMass = atomicMass;
            ElementCategory = elementCategory;
            MeltingPoint = meltingPoint;
            BoilingPoint = boilingPoint;
            Density = density;
            DefaultValence = defaultValence;
            OxidationStates = (sbyte[])oxidationStates.Clone();
        }
    }
}
