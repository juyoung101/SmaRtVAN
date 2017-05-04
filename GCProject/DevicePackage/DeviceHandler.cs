using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.DevicePackage
{
    public class DeviceHandler
    {
        public List<Device> inputDevices { get; set; }
        public List<Device> outputDevices { get; set; }

        public void generateDebugList()
        {
            Device solar_panel_1 = new Device();
            solar_panel_1.deviceName = "Solar Panel 1";
            solar_panel_1.energyAmount = "113";
            solar_panel_1.energyAmount = "100";
            solar_panel_1.history.Add(111);
            solar_panel_1.history.Add(116);
            solar_panel_1.history.Add(120);
            addInputDevice(solar_panel_1);

            Device wind_turbine_1 = new Device();
            wind_turbine_1.deviceName = "Turbine 1";
            wind_turbine_1.energyAmount = "60";
            wind_turbine_1.currentValue = 66;
            wind_turbine_1.history.Add(57);
            wind_turbine_1.history.Add(67);
            wind_turbine_1.history.Add(58);
            addInputDevice(wind_turbine_1);

            Device fridge = new DevicePackage.Device();
            fridge.deviceName = "Fridgy";
            fridge.energyAmount = "150";
            fridge.currentValue = 133;
            fridge.history.Add(202);
            fridge.history.Add(189);
            addOutputDevice(fridge);

            Device light = new Device();
            light.deviceName = "bulb1";
            light.energyAmount = "8";
            light.currentValue = 6;
            light.history.Add(5);
            light.history.Add(9);
            addOutputDevice(light);
        }
        public DeviceHandler()
        {
            inputDevices = new List<Device>();
            outputDevices = new List<Device>();
        }

        public void addInputDevice(Device d)
        {
            inputDevices.Add(d);
        }

        public void addOutputDevice(Device d)
        {
            outputDevices.Add(d);
        }

        public List<Device> getInputDevices()
        {
            return inputDevices;
        }

        public List<Device> getOutputDevics()
        {
            return outputDevices;
        }

        public decimal getInputEnergy()
        {
            decimal energy = 0;
            foreach(var i in inputDevices)
            {
                energy += i.read();
            }
            return energy;
        }

        public decimal getOutputEnergy()
        {
            decimal energy = 0;
            foreach (var o in outputDevices)
            {
                energy += o.read();
            }
            return energy;
        }

        public decimal getEnergyDifference()
        {
            decimal energy;
            energy = getInputEnergy() - getOutputEnergy();
            return energy;
        }

        public void updateDevices()
        {
            if(inputDevices != null && inputDevices.Count > 0)
            { 
                foreach(var a in inputDevices)
                {
                    a.update();
                }
            }

            if (inputDevices != null && inputDevices.Count > 0)
            {
                foreach (var b in outputDevices)
                {
                    b.update();
                }
            }
        }
        
    }
}
