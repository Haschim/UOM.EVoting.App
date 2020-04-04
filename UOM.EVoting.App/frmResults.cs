using System;
using System.Windows.Forms;

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

    }
}
