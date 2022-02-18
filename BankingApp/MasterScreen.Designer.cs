namespace BankingApp
{
    partial class MasterScreen
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
            this.butLogout = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labusername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butLogout
            // 
            this.butLogout.Location = new System.Drawing.Point(241, 254);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(216, 96);
            this.butLogout.TabIndex = 0;
            this.butLogout.Text = "Log Out";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(198, 139);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(127, 63);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnCB
            // 
            this.btnCB.Location = new System.Drawing.Point(423, 139);
            this.btnCB.Name = "btnCB";
            this.btnCB.Size = new System.Drawing.Size(127, 63);
            this.btnCB.TabIndex = 2;
            this.btnCB.Text = "Balance";
            this.btnCB.UseVisualStyleBackColor = true;
            this.btnCB.Click += new System.EventHandler(this.btnCB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome";
            // 
            // labusername
            // 
            this.labusername.AutoSize = true;
            this.labusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labusername.Location = new System.Drawing.Point(372, 9);
            this.labusername.Name = "labusername";
            this.labusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labusername.Size = new System.Drawing.Size(109, 39);
            this.labusername.TabIndex = 4;
            this.labusername.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "What would you like to do today?";
            // 
            // MasterScreen
            // 
            this.ClientSize = new System.Drawing.Size(859, 439);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCB);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.butLogout);
            this.Name = "MasterScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labusername;
        private System.Windows.Forms.Label label5;
    }
}