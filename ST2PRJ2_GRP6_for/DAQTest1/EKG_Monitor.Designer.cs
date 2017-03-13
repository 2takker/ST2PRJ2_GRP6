namespace ST2PRJ2_GRP6_for
{
    partial class EKG_Monitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnReadEKG = new System.Windows.Forms.Button();
            this.chartEKG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtBoxPulse = new System.Windows.Forms.TextBox();
            this.txtBoxHRV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEKG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadEKG
            // 
            this.btnReadEKG.Location = new System.Drawing.Point(40, 27);
            this.btnReadEKG.Name = "btnReadEKG";
            this.btnReadEKG.Size = new System.Drawing.Size(231, 62);
            this.btnReadEKG.TabIndex = 0;
            this.btnReadEKG.Text = "Indlæs EKG";
            this.btnReadEKG.UseVisualStyleBackColor = true;
            this.btnReadEKG.Click += new System.EventHandler(this.btnReadEKG_Click);
            // 
            // chartEKG
            // 
            this.chartEKG.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Interval = 0.2D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.Maximum = 10.6D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 0.04D;
            chartArea1.AxisX.ScaleView.Size = 2.2D;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.ScrollBar.Size = 20D;
            chartArea1.AxisX.Title = "s";
            chartArea1.AxisX2.MinorGrid.Enabled = true;
            chartArea1.AxisX2.MinorGrid.Interval = 20D;
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Interval = 0.5D;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.Maximum = 2D;
            chartArea1.AxisY.Minimum = -0.5D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 0.1D;
            chartArea1.AxisY.Title = "mV";
            chartArea1.AxisY2.MinorGrid.Enabled = true;
            chartArea1.AxisY2.MinorGrid.Interval = 0.1D;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartEKG.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartEKG.Legends.Add(legend1);
            this.chartEKG.Location = new System.Drawing.Point(40, 119);
            this.chartEKG.Name = "chartEKG";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.Name = "EKG";
            this.chartEKG.Series.Add(series1);
            this.chartEKG.Size = new System.Drawing.Size(2642, 1329);
            this.chartEKG.TabIndex = 2;
            this.chartEKG.Text = "chart1";
            // 
            // txtBoxPulse
            // 
            this.txtBoxPulse.Location = new System.Drawing.Point(363, 58);
            this.txtBoxPulse.Name = "txtBoxPulse";
            this.txtBoxPulse.Size = new System.Drawing.Size(192, 31);
            this.txtBoxPulse.TabIndex = 3;
            this.txtBoxPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxHRV
            // 
            this.txtBoxHRV.Location = new System.Drawing.Point(739, 58);
            this.txtBoxHRV.Name = "txtBoxHRV";
            this.txtBoxHRV.Size = new System.Drawing.Size(192, 31);
            this.txtBoxHRV.TabIndex = 4;
            this.txtBoxHRV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "HRV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "slag/min";
            // 
            // EKG_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2724, 1662);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxHRV);
            this.Controls.Add(this.txtBoxPulse);
            this.Controls.Add(this.chartEKG);
            this.Controls.Add(this.btnReadEKG);
            this.Name = "EKG_Monitor";
            this.Text = "EKG Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartEKG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadEKG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEKG;
        private System.Windows.Forms.TextBox txtBoxPulse;
        private System.Windows.Forms.TextBox txtBoxHRV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

