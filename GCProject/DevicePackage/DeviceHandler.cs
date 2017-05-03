﻿using System;
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
            inputDevices.Add(d);
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
            decimal energy = 0;
            energy += getInputEnergy();
            energy -= getOutputEnergy();
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
