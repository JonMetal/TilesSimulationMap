using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VisualPrototype.GameWorld.Simulation.Chemistry;
using VisualPrototype.GameWorld.Simulation.Phisycs;

namespace VisualPrototype.GameWorld.Simulation
{
    public class SimulationTile
    {
        public short Temperature { get; set; }  
        public short Pressure { get; set; }    
        public byte LightLevel { get; set; }

        public Vector2 ElectricField { get; set; }

        public decimal Gravity { get; set; }

        public float TemperatureK => Temperature / 10.0f;
        public float TemperatureC => (Temperature / 10.0f) - 273.15f;

        public float PressureAtm => Pressure / 100.0f;

        public event Action<SimulationTile, string> OnSharedDataChanged;

        protected void NotifyChange(string dataType)
        {
            OnSharedDataChanged?.Invoke(this, dataType);
        }
    }
}
