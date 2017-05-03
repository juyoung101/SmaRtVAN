using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.DevicePackage
{
    class DeviceHandler
    {
        public List<Device> inputDevices { get; set; }
        public List<Device> outputDevices { get; set; }

        public void addInputDevice(Device d)
        {
            inputDevices.Add(d);
        }

        public void addOutputDevice(Device d)
        {
            inputDevices.Add(d);
        }

        public void updateDevices()
        {
            foreach(var a in inputDevices)
            {
                a.update();
            }
            foreach(var b in outputDevices)
            {
                b.update();
            }
        }
        
    }
}
