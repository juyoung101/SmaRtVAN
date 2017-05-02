using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.SensorPackage
{
    abstract class iSensor
    {
        String SENSOR_DATA_TYPE_TAG { get; set; }
        String value { get; set; }
        String value_type { get; set; }
        public abstract void update();
    }
}
