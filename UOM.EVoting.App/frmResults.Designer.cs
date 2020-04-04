namespace UOM.EVoting.App
{
    partial class frmResults
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
            this.cboConstituencies = new System.Windows.Forms.ComboBox();
            this.chrtResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConstituencies
            // 
            this.cboConstituencies.FormattingEnabled = true;
            this.cboConstituencies.Location = new System.Drawing.Point(29, 22);
            this.cboConstituencies.Name = "cboConstituencies";
            this.cboConstituencies.Size = new System.Drawing.Size(470, 21);
            this.cboConstituencies.TabIndex = 0;
            this.cboConstituencies.SelectedValueChanged += new System.EventHandler(this.cboConstituencies_SelectedValueChanged);
            // 
            // chrtResults
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtResults.Legends.Add(legend1);
            this.chrtResults.Location = new System.Drawing.Point(29, 62);
            this.chrtResults.Name = "chrtResults";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chrtResults.Series.Add(series1);
            this.chrtResults.Size = new System.Drawing.Size(470, 242);
            this.chrtResults.TabIndex = 1;
            this.chrtResults.Text = "chart1";
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 326);
            this.Controls.Add(this.chrtResults);
            this.Controls.Add(this.cboConstituencies);
            this.Name = "frmResults";
            this.Text = "frmResults";
            ((System.ComponentModel.ISupportInitialize)(this.chrtResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConstituencies;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtResults;
    }
}