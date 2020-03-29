using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UOM.EVoting.App
{
    public partial class frmVoting : Form
    {

        public frmVoting()
        {
            InitializeComponent();
        }

        private Business.clsVotingBL objVotingBL;
        private Common.clsVoter objVoter;
        private List<Common.clsCandidate> lstCandidates;
        private Common.clsConstituency objConstituency;

        // Show the form
        public bool ShowDialog(Common.clsVoter objVoter)
        {
            bool fOk;

            // Initialisations
            objVotingBL = new Business.clsVotingBL();

            // Store the voter
            this.objVoter = objVoter;

            // Read the candidates of the constituency
            fOk = objVotingBL.ReadCandidates(objVoter.ConstituencyId, out lstCandidates);
            if (!fOk)
                return fOk;

            // Show the form
            this.ShowDialog();

            // Voter has voted
            fOk = true;

            return fOk;
        }

        // Form shown
        private void frmVoting_Shown(object sender, EventArgs e)
        {
            objVotingBL.ReadConstituency(objVoter.ConstituencyId, out objConstituency);
            txtInformation.Text = $"You are voiting in the consitiuency number {objConstituency.Id} : \t\t{objConstituency.Name}";

            // Declarations
            CheckBox chkCandidate;

            //List the candidates
            foreach (Common.clsCandidate objCandidate in lstCandidates)
            {
                chkCandidate = new CheckBox();
                chkCandidate.Tag = objCandidate;
                chkCandidate.Text = objCandidate.Name + " " + objCandidate.Surname;
                chkCandidate.AutoSize = true;
                flpCandidates.Controls.Add(chkCandidate);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Vote
        private void btnVote_Click(object sender, EventArgs e)
        {
            // Empty the list
            lstCandidates.Clear();

            // Check the candidates voted for
            foreach (CheckBox chkCandidate in flpCandidates.Controls)
            {
                if (chkCandidate.Checked)
                    lstCandidates.Add((Common.clsCandidate)chkCandidate.Tag);
            }

            // Any vote ?
            if (lstCandidates.Count != 3)
            {
                MessageBox.Show("INVALID_VOTE", "FORM_TITLE");
                return;
            }

            objVotingBL.Vote(objVoter, lstCandidates);

            //fVote = true;
            this.Close();
        }
    }
}
