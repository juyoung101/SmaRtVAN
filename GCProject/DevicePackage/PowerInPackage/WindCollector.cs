using GCProject.DevicePackage;
using GCProject.SensorPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.Collection
{
    public class WindCollector : Device
    {
        public string energyProductionAmount { get; set; }
        public iSensor time { get; set; }
        public bool isTimeSet = false;

        public void associateTimeSensor(iSensor a)
        {
            time = a;
            isTimeSet = true;
        }

        public decimal update()
        {
            decimal energy = 0;
            energy = Decimal.Parse(energyProductionAmount);
            if (isTimeSet)
            {
                var intTime = time.read().Split(':');
                var hour = int.Parse(intTime[0]);
                if (hour < 10 && hour > 4)
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
                energy -= (SensorHandler.getRandom() % 10) - 5;
            }
            makeHistory(energy);
            return energy;
        }
    }
}
