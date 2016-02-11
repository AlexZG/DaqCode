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
        private Sensor[] sensObj;
        private DataTable dataTbl;
        private bool first;
        private double dfltTimeSample;
        private double timeLeftSample;

        public mainForm()
        {
            InitializeComponent();

            first = true;
            dfltTimeSample = Settings.Default.sampleTime*10;
            timeLeftSample = dfltTimeSample;
            sensObj = Program.createSensors();
            dataTbl = Program.createTable();
            setupDGV();

        }
        //When btn sampling has been clicked it calls the method getTable and sets the value of the
        private void btnSampling_Click(object sender, EventArgs e)
        {
            if(lblCountSample.Text != "Ready for new Sample")
            {
                return;
            }
            txtSensorValue.Clear();
            dataTbl = getTable(dataTbl);
            dgvData.DataSource = dataTbl;
            tmrCountSample.Start();
            btnSampling.Enabled = false;

            if (first == true)
            {
                autoHeightDGV();
            }
        }


        private DataTable getTable(DataTable table)
        {
            table.Clear();
            table = Program.fillData(table, sensObj);
            return table;
        }
        private void setupDGV()
        {
            dgvData.DataSource = dataTbl;
            dgvData.AllowUserToAddRows = false;
            dgvData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.ScrollBars = ScrollBars.None;
            dgvData.RowHeadersWidth = 25;
            dgvData.Columns[0].Width = 60;
            dgvData.Columns[0].HeaderText = "Sensor ID";
            dgvData.Columns[1].Width = 100;
            dgvData.Columns[1].HeaderText = "Timestamp";
            dgvData.Columns[2].Width = 85;
            dgvData.Columns[2].HeaderText = "Signal type";
            dgvData.Columns[3].Width = 100;
            dgvData.Columns[3].HeaderText = "Sensor Value";
        }
        private void autoHeightDGV()
        {
            int sum = this.dgvData.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                sum += row.Height;
            }

            if (sum + 100 >= this.Height)
            {
                dgvData.Height = this.Height - 100;
                dgvData.ScrollBars = ScrollBars.Vertical;

            }
            else
            {
                dgvData.Height = sum;
            }
            first = false;
        }

        private void tmrCountSample_Tick(object sender, EventArgs e)
        {
 
            if (timeLeftSample > 0)
            {
                timeLeftSample = timeLeftSample - 1;
                lblCountSample.Text =  (timeLeftSample / 10).ToString("F1") + " Seconds";
            }
            else
            {
                tmrCountSample.Stop();
                timeLeftSample = dfltTimeSample;
                lblCountSample.Text = "Ready for new Sample";
                btnSampling.Enabled = true;
            }
        }
    }
}