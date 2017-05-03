using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.Collection
{
    public class SolarCollector
    {
        public string deviceName { get; set; }
        public string energyProductionAmount { get; set; }
        public List<decimal> history { get; set; }
        int historyIndex { get; set; }

        decimal read()
        {
            decimal energy = 0;
            energy = Decimal.Parse(energyProductionAmount);
            energy += (SensorHandler.getRandom() % 10) - 5;
            makeHistory(energy);
            return energy;
        }

        decimal getTrend()
        {
            if (history.Count == 0)
                return 0;
            return history.Average();
        }

        bool isTrendIncreasing()
        {
            decimal diff = 0;
            for (int i = 0; i < history.Count - 1; ++i)
            {
                diff += history[i + 1] - history[i];
            }

            if (diff < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void makeHistory(decimal energyIn)
        {
            if (history.Count < 5)
            {
                history.Add(energyIn);
                historyIndex = history.Count;
            }
            else
            {
                history[historyIndex] = energyIn;
                historyIndex = historyIndex++ % 5;
            }
        }
    }
}
