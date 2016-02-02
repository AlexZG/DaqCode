using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaqSimulator
{
    public partial class mainForm : Form
    {
        public int test = 1;
        public mainForm()
        {
            InitializeComponent();

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            txtSensorValue.Text = test.ToString();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}