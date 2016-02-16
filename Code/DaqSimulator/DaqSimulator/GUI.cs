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
        private static string path;
        private static string fileName;

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
            path = Settings.Default.filePath;
            fileName = Settings.Default.fileName;
            
            setupDesign();


        }
        //When btn sampling has been clicked it calls the method getTable and sets the value of the
        private void btnSampling_Click(object sender, EventArgs e)
        {
            tmrCountSample.Start();
            dataTbl = getTable(dataTbl);
            dgvData.DataSource = dataTbl;
            btnSampling.Enabled = false;

            if (first == true)
            {
                autoHeightDGV();
            }
        }

        //Gets values from program.filldata method
        private DataTable getTable(DataTable table)
        {
            table.Clear();
            table = Program.fillData(table, sensObj);
            return table;
        }
        //Sets up the design of the gui
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
            txtFileName.Text = Settings.Default.fileName;
        }
        //Method for rezise the data grid view 
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
        //Timer tick event for the count sample timer, this checks if time left is bigger than zero
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
        //Just tried to implement help box
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
        //Event if the about item is clicked, opens the about form
        private void itmAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.ShowDialog();
        }
        //Fills a string with the content of datatable
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
                MessageBox.Show(ex.ToString());
            }
            return sb.ToString();
        }
        //Event when button logging is clicked
        private void btnLogging_Click(object sender, EventArgs e)
        {
            tmrCountLogging.Start();
            logToFile(dataTbl);
        }
        //Method that writes a string to file
        private static void logToFile(DataTable dt)
        {
            try
            {

                path = Settings.Default.filePath;
                fileName = Settings.Default.fileName;
                if (string.IsNullOrEmpty(path))
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
                if (string.IsNullOrEmpty(fileName))
                {
                    fileName = "sensorLog.txt";
                }
                string filePath = Path.Combine(path, fileName);

                string logTxt = null;

                if (!File.Exists(filePath))
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
                MessageBox.Show(ex.ToString());
            }
        }
        //Code when file dialog browser is clicked, saves the selected path
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
            Settings.Default.filePath = fbdPath.SelectedPath;
            Settings.Default.fileName = txtFileName.Text;
            Settings.Default.Save();
            MessageBox.Show(Settings.Default.fileName);
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
                tmrCountLogging.Stop();
                timeLeftLogging = dfltTimeLogging;
                lblCountLogging.Text = "Ready for new Sampling";
                btnLogging.Enabled = true;
            }
        }
    }
}
 