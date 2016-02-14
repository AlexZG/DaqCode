namespace DaqSimulator
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.itmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEnableHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSampling = new System.Windows.Forms.GroupBox();
            this.lblCountSample = new System.Windows.Forms.Label();
            this.lblNextSampTime = new System.Windows.Forms.Label();
            this.btnSampling = new System.Windows.Forms.Button();
            this.grpLogging = new System.Windows.Forms.GroupBox();
            this.btnLogging = new System.Windows.Forms.Button();
            this.lblCountLogging = new System.Windows.Forms.Label();
            this.lblNextLoggTime = new System.Windows.Forms.Label();
            this.tmrCountSample = new System.Windows.Forms.Timer(this.components);
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.hlpProvider = new System.Windows.Forms.HelpProvider();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFBD = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpFilePath = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSaveFilePath = new System.Windows.Forms.Button();
            this.tmrCountLogging = new System.Windows.Forms.Timer(this.components);
            this.mnuTop.SuspendLayout();
            this.grpSampling.SuspendLayout();
            this.grpLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grpFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTop
            // 
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmFile,
            this.helpToolStripMenuItem,
            this.itmAbout});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuTop.Size = new System.Drawing.Size(769, 24);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // itmFile
            // 
            this.itmFile.Name = "itmFile";
            this.itmFile.Size = new System.Drawing.Size(37, 22);
            this.itmFile.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmEnableHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // itmEnableHelp
            // 
            this.itmEnableHelp.Name = "itmEnableHelp";
            this.itmEnableHelp.Size = new System.Drawing.Size(137, 22);
            this.itmEnableHelp.Text = "Enable Help";
            this.itmEnableHelp.Click += new System.EventHandler(this.itmEnableHelp_Click);
            // 
            // itmAbout
            // 
            this.itmAbout.Name = "itmAbout";
            this.itmAbout.Size = new System.Drawing.Size(52, 22);
            this.itmAbout.Text = "About";
            this.itmAbout.Click += new System.EventHandler(this.itmAbout_Click);
            // 
            // grpSampling
            // 
            this.grpSampling.Controls.Add(this.lblCountSample);
            this.grpSampling.Controls.Add(this.lblNextSampTime);
            this.grpSampling.Controls.Add(this.btnSampling);
            this.grpSampling.Location = new System.Drawing.Point(8, 31);
            this.grpSampling.Margin = new System.Windows.Forms.Padding(2);
            this.grpSampling.Name = "grpSampling";
            this.grpSampling.Padding = new System.Windows.Forms.Padding(2);
            this.grpSampling.Size = new System.Drawing.Size(369, 85);
            this.grpSampling.TabIndex = 1;
            this.grpSampling.TabStop = false;
            this.grpSampling.Text = "Sampling";
            // 
            // lblCountSample
            // 
            this.lblCountSample.AutoSize = true;
            this.lblCountSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSample.Location = new System.Drawing.Point(7, 41);
            this.lblCountSample.Name = "lblCountSample";
            this.lblCountSample.Size = new System.Drawing.Size(163, 15);
            this.lblCountSample.TabIndex = 3;
            this.lblCountSample.Text = "Ready for new Sampling";
            // 
            // lblNextSampTime
            // 
            this.lblNextSampTime.AutoSize = true;
            this.lblNextSampTime.Location = new System.Drawing.Point(7, 28);
            this.lblNextSampTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextSampTime.Name = "lblNextSampTime";
            this.lblNextSampTime.Size = new System.Drawing.Size(120, 13);
            this.lblNextSampTime.TabIndex = 2;
            this.lblNextSampTime.Text = "Time Until Next Sample:";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(10, 58);
            this.btnSampling.Margin = new System.Windows.Forms.Padding(2);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(162, 23);
            this.btnSampling.TabIndex = 1;
            this.btnSampling.Text = "Sample";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.btnLogging);
            this.grpLogging.Controls.Add(this.lblCountLogging);
            this.grpLogging.Controls.Add(this.lblNextLoggTime);
            this.grpLogging.Location = new System.Drawing.Point(8, 117);
            this.grpLogging.Margin = new System.Windows.Forms.Padding(2);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Padding = new System.Windows.Forms.Padding(2);
            this.grpLogging.Size = new System.Drawing.Size(369, 88);
            this.grpLogging.TabIndex = 3;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(10, 53);
            this.btnLogging.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(160, 23);
            this.btnLogging.TabIndex = 1;
            this.btnLogging.Text = "Logg To File";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // lblCountLogging
            // 
            this.lblCountLogging.AutoSize = true;
            this.lblCountLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLogging.Location = new System.Drawing.Point(7, 36);
            this.lblCountLogging.Name = "lblCountLogging";
            this.lblCountLogging.Size = new System.Drawing.Size(160, 15);
            this.lblCountLogging.TabIndex = 3;
            this.lblCountLogging.Text = "Ready For New Logging";
            // 
            // lblNextLoggTime
            // 
            this.lblNextLoggTime.AutoSize = true;
            this.lblNextLoggTime.Location = new System.Drawing.Point(7, 23);
            this.lblNextLoggTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextLoggTime.Name = "lblNextLoggTime";
            this.lblNextLoggTime.Size = new System.Drawing.Size(96, 13);
            this.lblNextLoggTime.TabIndex = 2;
            this.lblNextLoggTime.Text = "Next Logging Time";
            // 
            // tmrCountSample
            // 
            this.tmrCountSample.Tick += new System.EventHandler(this.tmrCountSample_Tick);
            // 
            // dgvData
            // 
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvData.Location = new System.Drawing.Point(382, 36);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(365, 252);
            this.dgvData.TabIndex = 5;
            // 
            // btnOpenFBD
            // 
            this.btnOpenFBD.Location = new System.Drawing.Point(315, 34);
            this.btnOpenFBD.Name = "btnOpenFBD";
            this.btnOpenFBD.Size = new System.Drawing.Size(44, 22);
            this.btnOpenFBD.TabIndex = 6;
            this.btnOpenFBD.Text = "...";
            this.btnOpenFBD.UseVisualStyleBackColor = true;
            this.btnOpenFBD.Click += new System.EventHandler(this.btnOpenFBD_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(10, 35);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(307, 20);
            this.txtPath.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 8;
            // 
            // grpFilePath
            // 
            this.grpFilePath.Controls.Add(this.lblFileName);
            this.grpFilePath.Controls.Add(this.lblPath);
            this.grpFilePath.Controls.Add(this.btnSaveFilePath);
            this.grpFilePath.Controls.Add(this.txtPath);
            this.grpFilePath.Controls.Add(this.textBox1);
            this.grpFilePath.Controls.Add(this.btnOpenFBD);
            this.grpFilePath.Location = new System.Drawing.Point(8, 206);
            this.grpFilePath.Name = "grpFilePath";
            this.grpFilePath.Size = new System.Drawing.Size(369, 133);
            this.grpFilePath.TabIndex = 9;
            this.grpFilePath.TabStop = false;
            this.grpFilePath.Text = "Logfile Settings";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(7, 60);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(49, 13);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "Filename";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(7, 20);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(71, 13);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "Physical Path";
            // 
            // btnSaveFilePath
            // 
            this.btnSaveFilePath.Location = new System.Drawing.Point(10, 104);
            this.btnSaveFilePath.Name = "btnSaveFilePath";
            this.btnSaveFilePath.Size = new System.Drawing.Size(160, 23);
            this.btnSaveFilePath.TabIndex = 9;
            this.btnSaveFilePath.Text = "Save Path And Filename";
            this.btnSaveFilePath.UseVisualStyleBackColor = true;
            this.btnSaveFilePath.Click += new System.EventHandler(this.btnSaveFilePath_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(769, 351);
            this.Controls.Add(this.grpFilePath);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.grpSampling);
            this.Controls.Add(this.mnuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "DAQ Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.grpSampling.ResumeLayout(false);
            this.grpSampling.PerformLayout();
            this.grpLogging.ResumeLayout(false);
            this.grpLogging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grpFilePath.ResumeLayout(false);
            this.grpFilePath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem itmFile;
        private System.Windows.Forms.GroupBox grpSampling;
        private System.Windows.Forms.Label lblNextSampTime;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.GroupBox grpLogging;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.Label lblNextLoggTime;
        private System.Windows.Forms.Timer tmrCountSample;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblCountSample;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmEnableHelp;
        private System.Windows.Forms.HelpProvider hlpProvider;
        private System.Windows.Forms.ToolStripMenuItem itmAbout;
        private System.Windows.Forms.Label lblCountLogging;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.Button btnOpenFBD;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpFilePath;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSaveFilePath;
        private System.Windows.Forms.Timer tmrCountLogging;
    }
}

