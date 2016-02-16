using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DaqSimulator.Properties;

namespace DaqSimulator
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        private static int nAna { get; set; }
        private static int nDig { get; set; }
        private static int nSen { get; set; }

        [STAThread]
        static void Main(string[] args)
        {

            nAna = Settings.Default.numAna;
            nDig = Settings.Default.numDig;
            nSen = nAna + nDig;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

        }
        public static Sensor[] createSensors()
        {
            Sensor[] senObj = new Sensor[nSen];
            if (nAna != 0 && nDig != 0)
            {
                
                for (int i = 0; i < nAna; i++)
                {
                    senObj[i] = new anaSensor();
                }
                for (int j = nAna; j < nAna + nDig; j++)
                {
                    senObj[j] = new digSensor();
                }
            }
            return senObj;
        }

        public static DataTable createTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("sensorID", typeof(int));
            table.Columns.Add("timeStamp", typeof(string));
            table.Columns.Add("sensorType", typeof(string));
            table.Columns.Add("sensorValue", typeof(double));
            return table;
           
            
        }

        public static DataTable fillData(DataTable filltable, Sensor[] sensObj)
        {
            int count = 0;
            foreach (Sensor element in sensObj)
            {
              
                DataRow row = filltable.NewRow();
                row["sensorID"] = sensObj[count].GetSensId;
                row["timeStamp"] = DateTime.Now.ToString("HH:mm:sss", new System.Globalization.CultureInfo("en-GB"));
                row["sensorType"] = sensObj[count].getSensType();
                row["sensorValue"] = sensObj[count].GetValue();
                filltable.Rows.Add(row);
                count++;
            }
            return filltable;
        }
         
    }
}
   

