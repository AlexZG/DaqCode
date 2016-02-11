using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaqSimulator.Properties;

namespace DaqSimulator
{
    class Sensor
    {
        private static int currentID;

        protected int sId { get; set; }
        protected string sensType { get; set; }

        protected double sVal { get; set; }
        protected Random rSensVal { get; set; }
        

        public Sensor()
        {
            sId = 0;
            sensType = "Unspecified";
            rSensVal = new Random(sId);
            sVal = 0.0F;
        }

        static Sensor()
        {
            currentID = 0;
        }

        protected int getNextId()
        {
            return ++currentID;
        }

        public virtual double GetValue()
        {
            return sVal;
        }

        public int GetSensId
        {
            get
            {
                return sId;
            }

        }

        public virtual string getSensType()
        {
            return sensType;
        }

    }

    ///////
    class anaSensor : Sensor
    {


        protected double maxV { get; set; }
        protected double minV { get; set; }

        public anaSensor()
        {
            sId = getNextId();
            sensType = "Analog";
            rSensVal = new Random(sId);
            sVal = 0.0F;

            maxV = Settings.Default.maxVoltLim;
            minV = Settings.Default.minVoltLim;
        }

        public override double GetValue()
        {
            sVal = Math.Round(rSensVal.NextDouble() *  (maxV - minV) + minV,3);
            return sVal;
        }
    }
    ///////
    class digSensor : Sensor
    {

        public digSensor()
        {
            sId = getNextId();
            sensType = "Digital";
            rSensVal = new Random(sId);
            sVal = 0.0F;
        }

        public override double GetValue()
        {
            sVal = rSensVal.Next(0,2);
            return sVal;
        }

    }
}


