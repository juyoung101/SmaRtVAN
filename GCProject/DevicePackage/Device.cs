using GCProject.SensorPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.DevicePackage
{
    public class Device
    {
        public string deviceName { get; set; }
        public string energyAmount { get; set; }
        public List<decimal> history { get; set; }
        //public int historyIndex { get; set; }
        public decimal currentValue { get; set; }

        public Device()
        {
            deviceName = "defaultDeviceName";
            energyAmount = "1";
            history = new List<decimal>();
            //historyIndex = 0;
            currentValue = 1;
        }
        
        public decimal read()
        {
            return currentValue;
        }

        public decimal update()
        {
            decimal energy = 0;
            energy = Decimal.Parse(energyAmount);
            energy += (SensorHandler.getRandom() % 10) - 5;
            makeHistory(energy);
            currentValue = energy;
            return energy;
        }

        public decimal getTrend()
        {
            if (history.Count == 0)
                return 0;
            return history.Average();
        }

        public bool isTrendIncreasing()
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

        public void makeHistory(decimal energyIn)
        {
            if (history.Count <= 5)
            {
                history.Add(energyIn);
                //historyIndex++;
            }
            else
            {
                history.RemoveAt(0);
                history.Add(energyIn);
                //history[historyIndex] = energyIn;
                //historyIndex = historyIndex++ % 5;
            }
        }

        public string toString()
        {
            return "" + read();
        }
    }
}
