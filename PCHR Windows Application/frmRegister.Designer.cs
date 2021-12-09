namespace PCHR_Windows_Application
{
    partial class frmRegister
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
            this.grpLoginDetails = new System.Windows.Forms.GroupBox();
            this.grpPersDetails = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grpLoginDetails
            // 
            this.grpLoginDetails.Location = new System.Drawing.Point(24, 37);
            this.grpLoginDetails.Name = "grpLoginDetails";
            this.grpLoginDetails.Size = new System.Drawing.Size(200, 100);
            this.grpLoginDetails.TabIndex = 0;
            this.grpLoginDetails.TabStop = false;
            this.grpLoginDetails.Text = "Login Details";
            this.grpLoginDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpPersDetails
            // 
            this.grpPersDetails.Location = new System.Drawing.Point(24, 217);
            this.grpPersDetails.Name = "grpPersDetails";
            this.grpPersDetails.Size = new System.Drawing.Size(200, 100);
            this.grpPersDetails.TabIndex = 0;
            this.grpPersDetails.TabStop = false;
            this.grpPersDetails.Text = "Personal Details";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 457);
            this.Controls.Add(this.grpPersDetails);
            this.Controls.Add(this.grpLoginDetails);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginDetails;
        private System.Windows.Forms.GroupBox grpPersDetails;
    }
}