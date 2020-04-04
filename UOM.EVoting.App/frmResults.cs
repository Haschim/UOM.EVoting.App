using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UOM.EVoting.App
{
    public partial class frmResults : Form
    {

        public frmResults()
        {
            InitializeComponent();

        }

        private Business.clsResultsBL ResultsBL;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ResultsBL = new Business.clsResultsBL();

            cboConstituencies.DataSource = ResultsBL.ReadConstituencies();
            cboConstituencies.DisplayMember = "Name";
            cboConstituencies.ValueMember = "Id";
        }

        private void cboConstituencies_SelectedValueChanged(object sender, EventArgs e)
        {
            Common.clsConstituency Constituency = (Common.clsConstituency)cboConstituencies.SelectedItem;
            List<Common.clsCandidate> Results = ResultsBL.ReadResults(Constituency);

            var ChartSeries = chrtResults.Series[0];
            ChartSeries.Points.Clear();
            ChartSeries.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            ChartSeries.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            foreach (var item in Results)
            {
                var point = ChartSeries.Points[ChartSeries.Points.AddXY(item.Surname.ToUpper() + " " + item.Name, item.Votes)];
            }
            chrtResults.ApplyPaletteColors();
        }
    }
}
