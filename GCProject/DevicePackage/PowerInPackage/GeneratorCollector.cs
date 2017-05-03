using GCProject.DevicePackage;
using GCProject.SensorPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.Collection
{
    public class GeneratorCollector : Device
    {
        public string energyProductionAmount { get; set; }

        decimal read()
        {
            decimal energy = 0;
            energy = Decimal.Parse(energyProductionAmount);
            energy += (SensorHandler.getRandom() % 10) - 5;
            makeHistory(energy);
            return energy;
        }
    }
}
