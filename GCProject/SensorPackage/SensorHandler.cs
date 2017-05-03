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

        //Function to get random number //BTW THIS WAS SOURCED FROM THE FIRST RESULT FOR "C# RANDOM NUMBER"
        private static Random getrandom = new Random();
        private static object syncLock = new object();
        public static int getRandom()
        {
            lock (syncLock)
            { // synchronize?
                return getrandom.Next();
            }
        }

        public SensorHandler(String filename_in)
        {
            sparser = new SensorParser(filename_in);
        }

        void addSensor(iSensor s)
        {
            sensors.Add(s);
        }

        void updateSensors()
        {
            string newData = sparser.readLine();
            var values = newData.Split(',');

            for(int i = 0; i < values.Length; ++i)
            {
                string tag = sparser.tags[i];
                foreach (iSensor s in sensors)
                {
                    if (s.SENSOR_DATA_TYPE_TAG == tag)
                    {
                        s.update(values[i]);
                        if(s.isInternal == true)
                        {
                            s.update(values[i] + ((getRandom() % 5) - 2));
                        }
                    }
                }
            }
        }

        public List<iSensor> getSensors()
        {
            return sensors;
        }
    }
}
