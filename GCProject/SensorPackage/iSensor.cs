using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.SensorPackage
{
    public class iSensor
    {
        public String SENSOR_DATA_TYPE_TAG { get; set; }
        public String value { get; set; }
        public String value_type { get; set; }
        public static iSensor makeSensor(String data_tag, String initialValue, String data_type)
        {
            iSensor a = new iSensor();
            a.SENSOR_DATA_TYPE_TAG = data_tag;
            a.value = initialValue;
            a.value_type = data_type;
            return a;
        }
        public void update(String newValue)
        {
            value = newValue;
        }

        public string read()
        {
            return this.value;
        }
    }
}
