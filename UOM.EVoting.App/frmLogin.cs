using System;
using System.Windows.Forms;

namespace UOM.EVoting.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private Common.clsVoter objVoter;

        private void btnOk_Click(object sender, EventArgs e)
        {

            bool isInputValid = true;

            try
            {
                // Verify inputs
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    txtLogin.Focus();
                    isInputValid = false;
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                    isInputValid = false;
                    return;
                }

                try
                {
                    var objLoginBL = new Business.clsLoginBL();
                    var objLoginData = new Common.clsLoginData();
                    objLoginData.Login = txtLogin.Text;
                    objLoginData.Password = txtPassword.Text;
                    this.objVoter = objLoginBL.Login(objLoginData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text);
                    return;
                }

                using (frmVoting frmVoting = new frmVoting())
                {
                    bool fOk;
                    fOk = frmVoting.ShowDialog(objVoter);
                    if (!fOk)
                    {
                        MessageBox.Show("VOTING_ERROR", this.Text);
                        return;
                    }
                }

            }
            finally
            {
                if (isInputValid)
                {
                    // Reset values
                    txtLogin.Clear();
                    txtPassword.Clear();
                    txtLogin.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llbResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(frmResults frmResults = new frmResults())
            {
                frmResults.ShowDialog();
            }
        }
    }
}
