namespace UOM.EVoting.App
{
    partial class frmVoting
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
            this.flpCandidates = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flpCandidates
            // 
            this.flpCandidates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCandidates.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCandidates.Location = new System.Drawing.Point(18, 95);
            this.flpCandidates.Name = "flpCandidates";
            this.flpCandidates.Size = new System.Drawing.Size(332, 231);
            this.flpCandidates.TabIndex = 0;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(186, 339);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(79, 23);
            this.btnVote.TabIndex = 3;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(18, 20);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            this.txtInformation.Size = new System.Drawing.Size(332, 33);
            this.txtInformation.TabIndex = 5;
            // 
            // txtInstruction
            // 
            this.txtInstruction.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstruction.Location = new System.Drawing.Point(18, 62);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ReadOnly = true;
            this.txtInstruction.Size = new System.Drawing.Size(332, 24);
            this.txtInstruction.TabIndex = 6;
            this.txtInstruction.Text = "You have to vote for 3 candidates from the list below:";
            // 
            // frmVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 383);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.flpCandidates);
            this.Name = "frmVoting";
            this.Text = "eVoting -  Cast your vote";
            this.Shown += new System.EventHandler(this.frmVoting_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCandidates;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.TextBox txtInstruction;
    }
}