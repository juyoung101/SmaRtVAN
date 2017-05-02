using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.SensorPackage
{
    public class SensorHandler
    {
        public List<iSensor> sensors { get; set; }
        public SensorParser sparser { get; set; }
        public List<String> tags { get; set; }

        //Function to get random number
        private Random getrandom = new Random();
        private object syncLock = new object();
        public int getRandom()
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next();
            }
        }

        public SensorHandler(String filename_in)
        {
            sparser = new SensorParser();
            sparser.filename = filename_in;
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
