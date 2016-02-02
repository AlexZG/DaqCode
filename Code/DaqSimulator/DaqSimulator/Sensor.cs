using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaqSimulator
{
    class Sensor
    {
        double dVal;
        int sId;
        Random rSensVal;
        public Sensor(int id)
        {
            sId = id;
            rSensVal = new Random(id);
            dVal = 0.0F;
        }
        public double GetValue()
        {
            dVal += rSensVal.NextDouble();
            return dVal;
        }
        public int GetSensId()
        {
            return sId;
        }
    }
}
