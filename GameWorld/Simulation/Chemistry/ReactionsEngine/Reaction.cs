using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry.ReactionsEngine
{
    public class Reaction
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Equation { get; init; } = "";

        public Dictionary<Compound, int> Reagents { get; private set; } = [];
        public Dictionary<Compound, int> Products { get; private set; } = [];

        public short MinTemperature { get; private set; }
        public short MinPressure { get; private set; }

        public bool RequiresElectricity { get; private set; }

        public decimal MinVoltage { get; private set; }

        public Compound[] Catalysts { get; private set; } = [];
        public Compound[] Inhibitors { get; private set; } = [];

        public decimal EnthalpyChange { get; private set; }
        public decimal EntropyChange { get; private set; }

        public decimal ActivationEnergy { get; private set; }
        public decimal PreExponentFactor { get; private set; }
        public decimal EquilibriumConstant { get; private set; }


    }
}
