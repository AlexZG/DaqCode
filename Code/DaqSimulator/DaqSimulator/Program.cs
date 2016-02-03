using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaqSimulator.Properties;

namespace DaqSimulator
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

        }
        public static Sensor[] createSensors()
        {
            int i;
            Sensor[] senObj = new Sensor[Settings.Default.numberOfSensors];
            for(i = 0;i < Settings.Default.numberOfSensors;i++)
            {
                senObj[i] = new Sensor(i);
            }
            return senObj;
        }
        public static double[] getValues(Sensor[] sensObj)
        {
            int i;
            double[] values = new double[Settings.Default.numberOfSensors];
            for(i = 0;i<Settings.Default.numberOfSensors;i++)
            {
                values[i] = sensObj[i].GetValue();
            }
            return values;
        }
    }
}
   

