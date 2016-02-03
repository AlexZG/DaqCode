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
            this.itmOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.itmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSampling = new System.Windows.Forms.GroupBox();
            this.lblNextSampTime = new System.Windows.Forms.Label();
            this.btnSampling = new System.Windows.Forms.Button();
            this.txtNextSampTime = new System.Windows.Forms.TextBox();
            this.grpLogging = new System.Windows.Forms.GroupBox();
            this.lblNextLoggTime = new System.Windows.Forms.Label();
            this.btnLogging = new System.Windows.Forms.Button();
            this.txtNextLoggTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSensorValue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnuTop.SuspendLayout();
            this.grpSampling.SuspendLayout();
            this.grpLogging.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTop
            // 
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmFile,
            this.itmOperations,
            this.itmHelp});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuTop.Size = new System.Drawing.Size(415, 24);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // itmFile
            // 
            this.itmFile.Name = "itmFile";
            this.itmFile.Size = new System.Drawing.Size(37, 22);
            this.itmFile.Text = "File";
            // 
            // itmOperations
            // 
            this.itmOperations.Name = "itmOperations";
            this.itmOperations.Size = new System.Drawing.Size(77, 22);
            this.itmOperations.Text = "Operations";
            // 
            // itmHelp
            // 
            this.itmHelp.Name = "itmHelp";
            this.itmHelp.Size = new System.Drawing.Size(44, 22);
            this.itmHelp.Text = "Help";
            // 
            // grpSampling
            // 
            this.grpSampling.Controls.Add(this.lblNextSampTime);
            this.grpSampling.Controls.Add(this.btnSampling);
            this.grpSampling.Controls.Add(this.txtNextSampTime);
            this.grpSampling.Location = new System.Drawing.Point(8, 31);
            this.grpSampling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSampling.Name = "grpSampling";
            this.grpSampling.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSampling.Size = new System.Drawing.Size(233, 102);
            this.grpSampling.TabIndex = 1;
            this.grpSampling.TabStop = false;
            this.grpSampling.Text = "Sampling";
            // 
            // lblNextSampTime
            // 
            this.lblNextSampTime.AutoSize = true;
            this.lblNextSampTime.Location = new System.Drawing.Point(5, 36);
            this.lblNextSampTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextSampTime.Name = "lblNextSampTime";
            this.lblNextSampTime.Size = new System.Drawing.Size(101, 13);
            this.lblNextSampTime.TabIndex = 2;
            this.lblNextSampTime.Text = "Next Sampling Time";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(7, 51);
            this.btnSampling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(97, 23);
            this.btnSampling.TabIndex = 1;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // txtNextSampTime
            // 
            this.txtNextSampTime.Location = new System.Drawing.Point(108, 34);
            this.txtNextSampTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNextSampTime.Name = "txtNextSampTime";
            this.txtNextSampTime.ReadOnly = true;
            this.txtNextSampTime.Size = new System.Drawing.Size(111, 20);
            this.txtNextSampTime.TabIndex = 0;
            this.txtNextSampTime.TabStop = false;
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.lblNextLoggTime);
            this.grpLogging.Controls.Add(this.btnLogging);
            this.grpLogging.Controls.Add(this.txtNextLoggTime);
            this.grpLogging.Location = new System.Drawing.Point(8, 149);
            this.grpLogging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLogging.Size = new System.Drawing.Size(233, 102);
            this.grpLogging.TabIndex = 3;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // lblNextLoggTime
            // 
            this.lblNextLoggTime.AutoSize = true;
            this.lblNextLoggTime.Location = new System.Drawing.Point(5, 36);
            this.lblNextLoggTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextLoggTime.Name = "lblNextLoggTime";
            this.lblNextLoggTime.Size = new System.Drawing.Size(96, 13);
            this.lblNextLoggTime.TabIndex = 2;
            this.lblNextLoggTime.Text = "Next Logging Time";
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(7, 51);
            this.btnLogging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(97, 23);
            this.btnLogging.TabIndex = 1;
            this.btnLogging.Text = "Logg To File";
            this.btnLogging.UseVisualStyleBackColor = true;
            // 
            // txtNextLoggTime
            // 
            this.txtNextLoggTime.Location = new System.Drawing.Point(108, 34);
            this.txtNextLoggTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNextLoggTime.Name = "txtNextLoggTime";
            this.txtNextLoggTime.ReadOnly = true;
            this.txtNextLoggTime.Size = new System.Drawing.Size(111, 20);
            this.txtNextLoggTime.TabIndex = 0;
            this.txtNextLoggTime.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSensorValue);
            this.groupBox2.Location = new System.Drawing.Point(252, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(158, 220);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Values";
            // 
            // txtSensorValue
            // 
            this.txtSensorValue.Location = new System.Drawing.Point(5, 17);
            this.txtSensorValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSensorValue.Multiline = true;
            this.txtSensorValue.Name = "txtSensorValue";
            this.txtSensorValue.ReadOnly = true;
            this.txtSensorValue.Size = new System.Drawing.Size(146, 201);
            this.txtSensorValue.TabIndex = 0;
            this.txtSensorValue.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(415, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.grpSampling);
            this.Controls.Add(this.mnuTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "DAQ Simulator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.grpSampling.ResumeLayout(false);
            this.grpSampling.PerformLayout();
            this.grpLogging.ResumeLayout(false);
            this.grpLogging.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem itmFile;
        private System.Windows.Forms.ToolStripMenuItem itmOperations;
        private System.Windows.Forms.ToolStripMenuItem itmHelp;
        private System.Windows.Forms.GroupBox grpSampling;
        private System.Windows.Forms.Label lblNextSampTime;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.TextBox txtNextSampTime;
        private System.Windows.Forms.GroupBox grpLogging;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSensorValue;
        private System.Windows.Forms.TextBox txtNextLoggTime;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.Label lblNextLoggTime;
        private System.Windows.Forms.Timer timer1;
    }
}

