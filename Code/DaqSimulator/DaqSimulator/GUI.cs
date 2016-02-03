using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaqSimulator.Properties;

namespace DaqSimulator
{
    
   

    public partial class mainForm : Form
         
    {
        Sensor[] sensObj = Program.createSensors();
        public int test = 1;
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            txtSensorValue.Clear();
            int i;
            double[] printValues = new double[Settings.Default.numberOfSensors];
            printValues = getValues();
            for (i = 0; i < printValues.Length; i++)
            {
                txtSensorValue.AppendText(sensObj[i].GetSensId().ToString() +  "\t" +  printValues[i].ToString("F3") + "\r\n");

            }
            

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
         
            
        }
        //This is a method that gets the values from the main program in type double array.
        private double[] getValues() 
        {
            double[] sensValues = new double[Settings.Default.numberOfSensors];
            sensValues = Program.getValues(sensObj);
            return sensValues;
        }
        
    }
}