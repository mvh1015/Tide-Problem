namespace Harrison_SWE_Intern_Problem
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxRange = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tideChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.michaelHarrisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tideChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(330, 353);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(229, 123);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(170, 363);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(154, 31);
            this.txtBoxID.TabIndex = 3;
            this.txtBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxRange
            // 
            this.txtBoxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRange.Location = new System.Drawing.Point(170, 437);
            this.txtBoxRange.Name = "txtBoxRange";
            this.txtBoxRange.Size = new System.Drawing.Size(154, 31);
            this.txtBoxRange.TabIndex = 5;
            this.txtBoxRange.Text = "14";
            this.txtBoxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(170, 400);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(154, 31);
            this.datePicker.TabIndex = 7;
            this.datePicker.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // tideChart
            // 
            chartArea5.AxisX.Title = "Time";
            chartArea5.AxisY.Title = "Height (ft)";
            chartArea5.Name = "ChartArea1";
            this.tideChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.tideChart.Legends.Add(legend5);
            this.tideChart.Location = new System.Drawing.Point(34, 53);
            this.tideChart.Name = "tideChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "TideSeries";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.tideChart.Series.Add(series5);
            this.tideChart.Size = new System.Drawing.Size(907, 285);
            this.tideChart.TabIndex = 8;
            this.tideChart.Text = "chart1";
            title5.Name = "tideTitle";
            this.tideChart.Titles.Add(title5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Location = new System.Drawing.Point(601, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 146);
            this.panel1.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorLabel.Location = new System.Drawing.Point(3, 73);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(333, 63);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(42, 42);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 20);
            this.lblMin.TabIndex = 1;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(42, 9);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 20);
            this.lblMax.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tide Station";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Range (Days)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(277, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOAA Tide Height Data Collector";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createdByToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createdByToolStripMenuItem
            // 
            this.createdByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.michaelHarrisonToolStripMenuItem});
            this.createdByToolStripMenuItem.Name = "createdByToolStripMenuItem";
            this.createdByToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createdByToolStripMenuItem.Text = "Created By";
            // 
            // michaelHarrisonToolStripMenuItem
            // 
            this.michaelHarrisonToolStripMenuItem.Name = "michaelHarrisonToolStripMenuItem";
            this.michaelHarrisonToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.michaelHarrisonToolStripMenuItem.Text = "Michael Harrison";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tideChart);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtBoxRange);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tideChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxRange;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart tideChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem michaelHarrisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

