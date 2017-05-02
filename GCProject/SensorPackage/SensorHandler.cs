using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.SensorPackage
{
    class SensorHandler
    {
        List<iSensor> sensors { get; set; }

        void updateSensors()
        {
            foreach(iSensor s in sensors)
            {
                s.update();
            }
        }

        bool hasUpdate()
        {

            return false;
        }

        List<iSensor> getSensors()
        {

            return sensors;
        }
    }
}
