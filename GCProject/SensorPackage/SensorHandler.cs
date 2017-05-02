using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.SensorPackage
{
    class SensorHandler
    {
        public List<iSensor> sensors { get; set; }
        public SensorParser sparser { get; set; }
        public List<String> tags { get; set; }

        public SensorHandler(String filename)
        {
            sparser.filename = filename;
        }

        void addSensor(iSensor s)
        {
            sensors.Add(s);
        }

        void updateSensors()
        {
            foreach(iSensor s in sensors)
            {
                s.update("");
            }
        }

        public List<iSensor> getSensors()
        {
            return sensors;
        }
    }
}
