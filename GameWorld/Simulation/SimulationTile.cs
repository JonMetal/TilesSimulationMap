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
        // Температура (K ×10) — ОДНА на весь тайл
        // Физика: теплопередача
        // Химия: скорость реакций, фазовые переходы
        public short Temperature { get; set; }

        // Давление (атм ×100) — сумма парциальных давлений газов
        // Физика: механика газов, течение
        // Химия: PV=nRT, равновесие
        public short Pressure { get; set; }

        // Плотность (кг/м³ ×100) — общая масса / общий объём
        // Физика: инерция, плавучесть
        // Химия: расчёт концентраций
        public decimal Density { get; set; }

        // Вязкость (Па·с ×10^6) — зависит от непрерывной фазы
        // Физика: сопротивление течению
        // Химия: диффузия, кинетика
        public decimal Viscosity { get; set; }

        public byte LightLevel { get; set; }

        // Электрическое поле (В/м ×100)
        public Vector2 ElectricField { get; set; }

        // Гравитация (м/с² ×100)
        public decimal Gravity { get; set; }

        public decimal TemperatureK => Temperature / 10.0m;
        public decimal TemperatureC => (Temperature / 10.0m) - 273.15m;

        public decimal PressureAtm => Pressure / 100.0m;
        public decimal DensityKgm3 => Density / 100.0m;
        public decimal ViscosityPas => Viscosity / 1e6m;
        public decimal GravityMps2 => Gravity / 100.0m;

        public event Action<SimulationTile, string>? OnSharedDataChanged;

        protected void NotifyChange(string dataType)
        {
            OnSharedDataChanged?.Invoke(this, dataType);
        }
    }
}
