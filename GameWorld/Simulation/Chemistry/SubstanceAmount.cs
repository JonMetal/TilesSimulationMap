using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPrototype.GameWorld.Simulation.Chemistry
{
    public class SubstanceAmount
    {
        public Compound Substance { get; init; }

        private decimal _moles;
        public decimal Moles
        {
            get => _moles;
            set
            {
                _moles = value;
                if (_moles < 0)
                {
                    _moles = 0;
                }
            }
        }

        public decimal Mass => Moles * Substance.MolarMass;

        public decimal VolumeAtSTP => Moles * 22.4m;

        public decimal Concentrations { get; set; }

        public SubstanceAmount(Compound substance, decimal moles)
        {
            Substance = substance;
            Moles = moles;
        }
    }
}
