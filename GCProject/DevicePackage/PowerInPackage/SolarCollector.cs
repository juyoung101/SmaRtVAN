using GCProject.DevicePackage;
using GCProject.SensorPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.Collection
{
    public class SolarCollector : Device
    {
        public string energyProductionAmount { get; set; }
        public iSensor time { get; set; }
        public bool isTimeSet = false;

        public void associateTimeSensor(iSensor a)
        {
            time = a;
            isTimeSet = true;
        }

        decimal read()
        {
            decimal energy = 0;
            energy = Decimal.Parse(energyProductionAmount);
            if (isTimeSet)
            {
                if (time.read().Contains('A')) //is before AM
                {
                    energy += (SensorHandler.getRandom() % 10) - 1;
                }
                else
                {
                    energy -= (SensorHandler.getRandom() % 10) - 9;
                }
            }
            else
            {
                energy += (SensorHandler.getRandom() % 10) - 5;
            }
            makeHistory(energy);
            return energy;
        }


    }
}
