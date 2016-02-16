using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DaqSimulator.Properties;

namespace DaqSimulator
{



    public partial class mainForm : Form

    {
        private Sensor[] sensObj;
        private DataTable dataTbl;
        private bool first;
        private double dfltTimeSample;
        private double dfltTimeLogging;
        private double timeLeftSample;
        private double timeLeftLogging;

        public mainForm()
        {
            InitializeComponent();
            first = true;
            dfltTimeSample = Settings.Default.sampleTime*10;
            dfltTimeLogging = Settings.Default.dfltTimeLogging * 10;
            timeLeftSample = dfltTimeSample;
            timeLeftLogging = 290;
            sensObj = Program.createSensors();
            dataTbl = Program.createTable();
            setupDesign();
            hlpProvider.SetHelpString(btnSampling, "Hello World");
            hlpProvider.SetHelpString(btnLogging, "DU HAST");

        }
        //When btn sampling has been clicked it calls the method getTable and sets the value of the
        private void btnSampling_Click(object sender, EventArgs e)
        {
            if(lblCountSample.Text != "Ready for new Sampling")
            {
                return;
            }
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
        private void setupDesign()
        {
            dgvData.DataSource = dataTbl;
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToResizeColumns = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.ScrollBars = ScrollBars.None;
            dgvData.RowHeadersWidth = 20;
            dgvData.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[0].Width = 60;
            dgvData.Columns[0].HeaderText = "Sensor ID";
            dgvData.Columns[1].Width = 100;
            dgvData.Columns[1].HeaderText = "Timestamp";
            dgvData.Columns[2].Width = 85;
            dgvData.Columns[2].HeaderText = "Signal type";
            dgvData.Columns[3].Width = 100;
            dgvData.Columns[3].HeaderText = "Sensor Value";
            txtPath.Text = Settings.Default.filePath;
        }
        private void autoHeightDGV()
        {
            int sum = this.dgvData.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                sum += row.Height;
            }

            if (sum + 60 >= this.Height)
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
                lblCountSample.Text = "Ready for new Sampling";
                btnSampling.Enabled = true;
            }
        }

        private void itmEnableHelp_Click(object sender, EventArgs e)
        {
            if(itmEnableHelp.Checked == false)
            {
                itmEnableHelp.Checked = true;
            }
            else
            {
                itmEnableHelp.Checked = false;
            }
        }

        private void itmAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.ShowDialog();
        }
        private static string dataTableToCSV(DataTable table,bool newFile)
        {
            StringBuilder sb = new StringBuilder();
            char seperator = ',';
            try {
                if(newFile == true)
                {
                    int count = 0;
                    foreach (DataColumn dr in table.Columns)
                    {
                        sb.Append(dr.ColumnName);
                        if (count < table.Columns.Count -1)
                        {
                            sb.Append(seperator);
                        }
                        count++;
                    }
                    sb.AppendLine();
                    newFile = false;
                }
                foreach (DataRow row in table.Rows)
                {
                    string value = null;
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        value = row[i].ToString();
                        if (value.Contains(","))
                        {
                            value = value.Replace(",", ".");
                        }
                        sb.Append(value);
                        if (i < table.Columns.Count - 1)
                        {
                            sb.Append(seperator);
                        }
                    }
                    sb.AppendLine();
                }
                
            }
            catch(Exception ex)
            {
                //TODO Enter code that cathces some exeption
            }
            return sb.ToString();
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            logToFile(dataTbl, @"c:\temp\", @"\MyTest.txt");
        }
        private static void logToFile(DataTable dt,string path,string fileName)
        {
            try
            {

            
            string mydocpath =
                                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string logTxt = null;
            string filePath = mydocpath + fileName;
            if (!File.Exists(mydocpath + fileName))
            {
                logTxt = dataTableToCSV(dt,true);
             
            }
            else
            {
                logTxt = dataTableToCSV(dt, false);
               
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.Write(logTxt);
            }
            }
            catch(Exception ex)
            {
               //TODO enter code that cathces path error exeption
            }
        }

        private void btnOpenFBD_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdPath.ShowDialog();
            if(result == DialogResult.OK)
            {
                Settings.Default.filePath = fbdPath.SelectedPath;
                txtPath.Text = fbdPath.SelectedPath;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void btnSaveFilePath_Click(object sender, EventArgs e)
        {
            // TODO Make logics to test the input for the txtboxes, test if path and filename is good then save to settings.
        }

        private void tmrCountLogging_Tick(object sender, EventArgs e)
        {
            if (timeLeftLogging > 0)
            {
                timeLeftLogging--;
                lblCountLogging.Text = (timeLeftLogging / 10).ToString("F1") + " Seconds";
            }
            else
            {
                tmrCountSample.Stop();
                timeLeftSample = dfltTimeSample;
                lblCountSample.Text = "Ready for new Sampling";
                btnSampling.Enabled = true;
            }
        }
    }
}
 