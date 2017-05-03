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
        public iSensor date_sensor { get; set; }
        public iSensor time_sensor { get; set; }

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
            sensors = new List<iSensor>();
            sparser = new SensorParser(filename_in);
            date_sensor = iSensor.makeSensor("DATE", "01/01/1970", "String", false);
            time_sensor = iSensor.makeSensor("TIME", "12:59", "String", false);
        }

        void addSensor(iSensor s)
        {
            sensors.Add(s);
        }

        public void updateSensors()
        {
            string newData = sparser.readLine();
            if (newData != null)
            { 
                var values = newData.Split(',').ToList<String>();
                date_sensor.update(values[0] ?? "01/01/1970");
                time_sensor.update((values[1] ?? "12:59") + (values[2] ?? "AM"));

                for (int i = 3; i < values.Count; ++i)
                {
                    string tag = sparser.tags[i];
                    foreach (iSensor s in sensors)
                    {
                        if (s.SENSOR_DATA_TYPE_TAG == tag)
                        {
                            s.update(values[i]);
                            if (s.isInternal == true)
                            {
                                s.update(values[i] + ((getRandom() % 5) - 2));
                            }
                        }
                    }
                }
            }   
        }

        public iSensor getDateSensor()
        {
            return date_sensor;
        }

        public iSensor getTimeSensor()
        {
            return time_sensor;
        }

        public List<iSensor> getSensors()
        {
            return sensors;
        }
    }
}
